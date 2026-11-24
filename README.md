MatchZy - Match Plugin for CS2!
==============

**English** | [Русский](README.ru.md)

MatchZy is a plugin for CS2 (Counter Strike 2) for running and managing practice/pugs/scrims/matches with easy configuration!

> **This is a fork** of [shobhit-pathak/MatchZy](https://github.com/shobhit-pathak/MatchZy) for LAN tournaments, used by [Matchdesk](https://github.com/a3v4r/Matchdesk). The fork notes come first; everything from "Feature Highlights" on is the original description.

## What is different from the original

- **Russian by default.** Messages use `matchzy_language` (`cfg/MatchZy/config.cfg`, default `ru`) instead of the CounterStrikeSharp `ServerLanguage`. Set `en` or any other file name from `lang/`, or leave it empty to follow `ServerLanguage` as the original does.
- **Works on Windows servers.** Demo recording (`tv_record`) and round backups (`mp_backup_*`) use paths relative to `csgo/`. CS2 on Windows rejects absolute paths, so with the original no demo and no round backup is written there.
- **Round restore for matches without a config.** `get5_status` also reports a match started with `.ready` or `css_start` (state, match id, round, scores), so a panel can list and restore its round backups.
- **More in `get5_status` for panels:** `round_clock` with the in-game timer (phase and seconds left), and the right team scores during the halftime break.
- **Settings from `config.cfg` always apply.** It runs on the next frame after the plugin loads; on a cold server start the original could run it too early and silently ignore the settings.
- **Tournament defaults:** 4 tactical timeouts of 20 s per map and none added in overtime (`live.cfg`); one technical pause per team per map, which either team can end after 15 minutes; neutral `[Server]` chat prefix and `{TEAM1} vs {TEAM2}` hostname; no credits message at match start.
- **Whitelist:** a match config with an empty player list lets everyone in instead of kicking them.

## Install

1. Install [Metamod:Source](https://www.sourcemm.net/downloads.php?branch=dev) and [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp/releases) (the `with-runtime` build).
2. Download `MatchZy-<version>.zip` from [Releases](https://github.com/a3v4r/MatchZy-Patched/releases) and extract it into `game/csgo` (it contains `addons/` and `cfg/`).
3. Restart the server. Settings are in `cfg/MatchZy/config.cfg`.

[Matchdesk](https://github.com/a3v4r/Matchdesk) installs and updates the plugin by itself.

[![Discord](https://discordapp.com/api/guilds/1169549878490304574/widget.png?style=banner2)](https://discord.gg/2zvhy9m7qg)

## Feature Highlights:

* Pug mode with simple commands to manage!
* Support of [Get5 Panel!](https://shobhit-pathak.github.io/MatchZy/get5/)
* Support BO1/BO3/BO5 and Veto when using Match configuration or Get5 Panel!
* [Setting up matches](https://shobhit-pathak.github.io/MatchZy/match_setup/) and locking players into their team
* Practice Mode with `.bot`, `.spawn`, `.ctspawn`, `.tspawn`, `.nobots`, `.rethrow`, `.last`, `.timer`, `.clear`, `.exitprac` and many more commands!
* Knife round (With expected logic, i.e., team with most players win. If same number of players, then team with HP advantage wins. If same HP, winner is decided randomly)
* Automatically starts demo recording and stop recording when match is ended (Make sure you have tv_enable 1)
* Automatically uploads demo on map end on the given URL.
* Players whitelisting (Thanks to [DEAFPS](https://github.com/DEAFPS)!)
* Coaching system
* Damage report after every round
* Support for round restore (Currently using the vanilla valve's backup system)
* Ability to create admin and allowing them access to admin commands
* Database Stats and CSV Stats! MatchZy stores data and stats of all the matches in a local SQLite database (MySQL Database is also supported!) and also creates a CSV file for detailed stats of every player in that match!
* Provides easy configuration
* And much more!!


## Documentation

## [shobhit-pathak.github.io/MatchZy/](https://shobhit-pathak.github.io/MatchZy/)

## Donation

Buy Me A Coffee:

[!["Buy Me A Coffee"](https://cdn.buymeacoffee.com/buttons/default-blue.png)](https://www.buymeacoffee.com/shobhitwd)

Steam Tradelink: 

https://steamcommunity.com/tradeoffer/new/?partner=194101533&token=1TI76S3p

## Want CS2 Server with MatchZy?

Buy it from DatHost (MatchZy can be installed directly on DatHost servers by using their 1-click installer from mods and plugins section!):
https://dathost.net/r/matchzy 

## License
MIT

## Credits and thanks!
* [Get5](https://github.com/splewis/get5) - A lot of functionalities and workings have been referred from Get5 and they did an amazing job for managing matches in CS:GO. Huge thanks to them!
* [G5V](https://github.com/PhlexPlexico/G5V) and [G5API](https://github.com/PhlexPlexico/G5API) - Amazing work with the web panel for managing the servers!
* [eBot](https://github.com/deStrO/eBot-CSGO) - Amazing job in CS:GO and then provided this great panel again in CS2 which is helping a lot of organizers now. Some logics have been referred from eBot as well!
* [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp/) - Amazing job with development of CSSharp which gave us a platform to build our own plugins and also sparked my interest in plugin development!
* [AlliedModders and community](https://alliedmods.net/) - They are the reason this whole plugin was possible! They are very helpful and inspire a lot!
* [LOTGaming](https://lotgaming.xyz/) - Helped me a lot with initial testing and provided servers on different systems and locations!
* [CHR15cs](https://github.com/CHR15cs) - Helped me a lot with the practice mode!
* [K4ryuu](https://github.com/K4ryuu) - Awesome job on damage report!
* [DEAFPS](https://github.com/DEAFPS) - Great contribution for Practice mode!
