using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class TeamStatistics
    {
        private enum PlayerStart
        {
            StartingEleven,
            Substitute
        }

        public string Country { get; set; }
        public int Attempts_on_goal { get; set; }
        public int On_target { get; set; }
        public int Off_target { get; set; }
        public int Blocked { get; set; }
        public int Woodwork { get; set; }
        public int Corners { get; set; }
        public int Offsides { get; set; }
        public int Ball_possession { get; set; }
        public int Pass_accuracy { get; set; }
        public int Num_passes { get; set; }
        public int Passes_completed { get; set; }
        public int Distance_covered { get; set; }
        public int Balls_recovered { get; set; }
        public int Tackles { get; set; }
        public int Clearances { get; set; }
        public int Yellow_cards { get; set; }
        public int Red_cards { get; set; }
        public int Fouls_committed { get; set; }
        public string Tactics { get; set; }
        public List<Player> Starting_eleven { get; set; }
        public List<Player> Substitutes { get; set; }

        public override string ToString()
        {
            return $"\n\tCountry: {Country}\n\tAttempts on goal: {Attempts_on_goal}\n\tOn target: {On_target}\n\tOff target: {Off_target}\n\tBlocked: {Blocked}\n\tWoodwoork: {Woodwork}\n\tCorners: {Corners}\n\tOffsides: {Offsides}\n\tBall possession: {Ball_possession}\n\tPass accuracy: {Pass_accuracy}\n\tNumber of passes: {Num_passes}\n\tDistance covered: {Distance_covered}\n\tBalls recovered: {Balls_recovered}\n\tTackles: {Tackles}\n\tClearances: {Clearances}\n\tYellow cards: {Yellow_cards}\n\tRed cards: {Red_cards}\n\tFouls commited: {Fouls_committed}\n\tTactics: {Tactics}\n\tStarting eleven: {GetPlayers(PlayerStart.StartingEleven)}\n\tSubstitutes: {GetPlayers(PlayerStart.Substitute)}";
        }

        private string GetPlayers(PlayerStart playerStart)
        {
            List<string> playersAsStringArray = new List<string>();

            switch (playerStart)
            {
                case PlayerStart.StartingEleven:
                    foreach (var teamEvent in Starting_eleven)
                    {
                        playersAsStringArray.Add(teamEvent.ToString());
                    }
                    break;
                case PlayerStart.Substitute:
                    foreach (var teamEvent in Substitutes)
                    {
                        playersAsStringArray.Add(teamEvent.ToString());
                    }
                    break;
            }

            string players = string.Join("\n\t", playersAsStringArray.ToArray());
            return players;
        }
    }

}
