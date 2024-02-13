using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Match
    {
        private enum TeamSide
        {
            Home,
            Away
        }

        public string Venue { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string Time { get; set; }
        public string Fifa_id { get; set; }
        public Weather Weather { get; set; }
        public string Attendance { get; set; }
        public List<string> Officials { get; set; }
        public string Stage_name { get; set; }
        public string Home_team_country { get; set; }
        public string Away_team_country { get; set; }
        public DateTime Datetime { get; set; }
        public string Winner { get; set; }
        public string Winner_code { get; set; }
        public MatchTeam Home_team { get; set; }
        public MatchTeam Away_team { get; set; }
        public List<TeamEvent> Home_team_events { get; set; }
        public List<TeamEvent> Away_team_events { get; set; }
        public TeamStatistics Home_team_statistics { get; set; }
        public TeamStatistics Away_team_statistics { get; set; }
        public DateTime Last_event_update_at { get; set; }
        public DateTime Last_score_update_at { get; set; }

        public override string ToString()
        {
            return $"Venue: {Venue}\nLocation: {Location}\nStatus: {Status}\nTime: {Time}\nFifaID: {Fifa_id}\nWeather: {Weather}\nAttendance: {Attendance}\nStage name: {Stage_name}\nHome team country: {Home_team_country}\nAway team country: {Away_team_country}\nDate time: {Datetime}\nWinner: {Winner}\nWinner code: {Winner_code}\nHome team: {Home_team}\nAway team: {Away_team}\nHome team events: {GetTeamEvents(TeamSide.Home)}\nAway team events: {GetTeamEvents(TeamSide.Away)}\nHome team statistics: {Home_team_statistics}\nAway team statistics: {Away_team_statistics}\nLast event update at: {Last_event_update_at}\nLast score update at: {Last_score_update_at}";
        }

        public string MatchesForRankingsToString()
        {
            return $"Attendance: {Attendance} - {Location} - {Home_team.Country} vs. {Away_team.Country}";
        }

        private string GetTeamEvents(TeamSide teamSide)
        {
            List<string> teamEventsAsStringArray = new List<string>();

            switch (teamSide)
            {
                case TeamSide.Home:
                    foreach (var teamEvent in Home_team_events)
                    {
                        teamEventsAsStringArray.Add(teamEvent.ToString());
                    }
                    break;
                case TeamSide.Away:
                    foreach (var teamEvent in Away_team_events)
                    {
                        teamEventsAsStringArray.Add(teamEvent.ToString());
                    }
                    break;
            }

            return string.Join("\n\t", teamEventsAsStringArray.ToArray());
        }
    }
}
