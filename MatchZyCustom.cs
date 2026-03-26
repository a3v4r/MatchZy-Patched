using Newtonsoft.Json.Linq;

namespace MatchZy
{
    public partial class MatchZy
    {
        public bool IsTeamWhitelistEmpty()
        {
            return (matchzyTeam1.teamPlayers == null || !matchzyTeam1.teamPlayers.HasValues) &&
                   (matchzyTeam2.teamPlayers == null || !matchzyTeam2.teamPlayers.HasValues);
        }
    }
}
