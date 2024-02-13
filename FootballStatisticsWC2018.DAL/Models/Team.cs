using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Fifa_code { get; set; }
        public int Group_id { get; set; }
        public string Group_letter { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int Games_played { get; set; }
        public int Points { get; set; }
        public int Goals_for { get; set; }
        public int Goals_against { get; set; }
        public int Goal_differential { get; set; }
               
        public override string ToString()
        {
            return $"ID: {Id}\n\tCountry: {Country}\n\tFifa code: {Fifa_code}\n\tGroup ID: {Group_id}\n\tGroup letter: {Group_letter}\n\tWins: {Wins}\n\tDraws: {Draws}\n\tLosses: {Losses}\n\tGames played: {Games_played}\n\tPoints: {Points}\n\tGoals for: {Goals_for}\n\tGoals against: {Goals_against}\n\tGoal differential: {Goal_differential}\n";
        }
    }
}
