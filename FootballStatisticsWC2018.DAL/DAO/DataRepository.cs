using DataAccessLayer.Models;
using DataAccessLayer.Comparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataAccessLayer.DAO
{
    public class DataRepository
    {
        public static string fifaCode;

        public static Dictionary<string, string> GetTeams_NamesFifaCode()
        {
            Dictionary<string, string> teamsNameFifaCode = new Dictionary<string, string>();
            List<Team> teamsFromAPI = TeamsAPI.GetTeamsAPI();

            teamsFromAPI.ForEach(team => teamsNameFifaCode.Add(team.Fifa_code, team.Country));

            return teamsNameFifaCode;
        }

        public static List<Team> GetTeams()
        {
            List<Team> teams = TeamsAPI.GetTeamsAPI();

            return teams; 
        }

        public static int GetTeamGoals(string favTeamName, string oppTeamName, string code)
        {
            List<Match> matchesFormAPI = MatchesAPI.GetMatchesAPI(code);

            int countGoals = 0;

            foreach (var match in matchesFormAPI)
            {
                if (match.Home_team.Country == favTeamName && match.Away_team.Country == oppTeamName)
                {
                    countGoals = match.Home_team.Goals;
                }
                else if (match.Away_team.Country == favTeamName && match.Home_team.Country == oppTeamName)
                {
                    countGoals = match.Away_team.Goals;
                }
            }

            return countGoals;
        }
               

        public static List<Match> GetMatches(string code)
        {
            List<Match> matchesFormAPI = MatchesAPI.GetMatchesAPI(code);

            return matchesFormAPI;
        }

        public static IEnumerable<Player> GetPlayers()
        {
            List<Match> matchesFormAPI = MatchesAPI.GetMatchesAPI(fifaCode);

            foreach (var match in matchesFormAPI)
            {
                if (match.Home_team.Code == fifaCode)
                {
                    var players = match.Home_team_statistics.Starting_eleven.Union(match.Home_team_statistics.Substitutes, new PlayerComparer());

                    return players;
                }
                else if (match.Away_team.Code == fifaCode)
                {
                    var players = match.Away_team_statistics.Starting_eleven.Union(match.Away_team_statistics.Substitutes, new PlayerComparer());

                    return players;
                }
            }
            return null;
        }

        public static List<Player> GetStartingEleven(string favCode, string oppCode)
        {
            List<Match> matches = MatchesAPI.GetMatchesAPI(favCode);

            foreach (var match in matches)
            {
                if(match.Home_team.Code == favCode && match.Away_team.Code == oppCode)
                {
                    var startingEleven = match.Home_team_statistics.Starting_eleven;

                    return startingEleven;
                }
                else if (match.Away_team.Code == favCode && match.Home_team.Code == oppCode)
                {
                    var startingEleven = match.Away_team_statistics.Starting_eleven;

                    return startingEleven;
                }
            }
            return null;
        }

        public static List<Match> GetMatchesForRankings()
        {
            List<Match> matchesFromAPI = MatchesAPI.GetMatchesAPI(fifaCode);
            List<Match> matchesForRankings = new List<Match>();

            foreach (var match in matchesFromAPI)
            {
                matchesForRankings.Add(new Match
                {
                    Location = match.Location,
                    Attendance = match.Attendance,
                    Home_team = match.Home_team,
                    Away_team = match.Away_team
                });
            }

            return matchesForRankings;
        }
        
        public static List<TeamEvent> GetTeamEventsForRankings()
        {
            List<Match> matchesFromAPI = MatchesAPI.GetMatchesAPI(fifaCode);
            List<TeamEvent> teamEventsForRankings = new List<TeamEvent>();

            foreach (var match in matchesFromAPI)
            {
                foreach (var teamEvent in match.Home_team_events)
                {
                    teamEventsForRankings.Add(new TeamEvent
                    {
                        Id = teamEvent.Id,
                        PlayerName = teamEvent.PlayerName,
                        Type_of_event = teamEvent.Type_of_event,
                        Time = teamEvent.Time
                    });
                }
            }

            return teamEventsForRankings;
        }

        public static void SaveFavTeam(string favTeam)
        {
            const string favTeamFile = @"E:\Dev Projects\UC Algebra\Semester IV - OOP .NET\DotNetProject\WindowsForms\saves/favTeamSave.txt";
            const string favTeamFolder = @"E:\Dev Projects\UC Algebra\Semester IV - OOP .NET\DotNetProject\WindowsForms\saves";

            if (!Directory.Exists(favTeamFolder))
            {
                Directory.CreateDirectory(favTeamFolder);
            }

            if (!File.Exists(favTeamFile))
            {
                File.Create(favTeamFile).Close();
            }

            File.WriteAllText(favTeamFile, favTeam);
        }
    }
}
 