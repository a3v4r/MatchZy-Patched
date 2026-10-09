using System.Globalization;
using CounterStrikeSharp.API.Modules.Cvars;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json.Linq;

namespace MatchZy
{
    public partial class MatchZy
    {
        public FakeConVar<string> matchzyLanguage = new("matchzy_language", "Language of MatchZy messages (lang/<code>.json). Empty = CounterStrikeSharp ServerLanguage. Default: ru", "ru");

        public bool IsTeamWhitelistEmpty()
        {
            return (matchzyTeam1.teamPlayers == null || !matchzyTeam1.teamPlayers.HasValues) &&
                   (matchzyTeam2.teamPlayers == null || !matchzyTeam2.teamPlayers.HasValues);
        }

        private void UseMatchZyLanguage()
        {
            if (Localizer is not FixedLanguageLocalizer)
            {
                Localizer = new FixedLanguageLocalizer(Localizer, () => matchzyLanguage.Value);
            }
        }
    }

    // Resolves MatchZy messages in matchzy_language instead of the server-wide CounterStrikeSharp language.
    public class FixedLanguageLocalizer(IStringLocalizer inner, Func<string> language) : IStringLocalizer
    {
        public LocalizedString this[string name] => InLanguage(() => inner[name]);

        public LocalizedString this[string name, params object[] arguments] => InLanguage(() => inner[name, arguments]);

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures) => InLanguage(() => inner.GetAllStrings(includeParentCultures).ToList());

        private T InLanguage<T>(Func<T> lookup)
        {
            string code = language().Trim();
            if (code == "") return lookup();

            CultureInfo previous = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo(code);
                return lookup();
            }
            catch (CultureNotFoundException)
            {
                return lookup();
            }
            finally
            {
                CultureInfo.CurrentUICulture = previous;
            }
        }
    }
}
