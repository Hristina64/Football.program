using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Program
    {
        static void Main(string[] args)
        {
            var goalkeeper = new Goalkeeper { Name = "Georgi", Age = 20, Number = 10, Height = 180 };
            var defender1 = new Defender { Name = "Ivan", Age = 22, Number = 15, Height = 190 };
            var midfield1 = new Midfield { Name = "Daniel", Age = 26, Number = 8, Height = 178 };
            var striker1 = new Striker { Name = "Radoslav", Age = 30, Number = 3, Height = 187 };
            var striker2 = new Striker { Name = "Dimitur", Age = 22, Number = 11, Height = 190 };

            var coach = new Coach { Name = "Peter", Age = 38 };
            var referee = new Referee { Name = "Kiril", Age = 30 };

            var team1 = new Team { Coach = coach, Players = new List<FootballPlayer> { goalkeeper, defender1, midfield1, striker1 } };
            var team2 = new Team { Coach = coach, Players = new List<FootballPlayer> { goalkeeper, defender1, midfield1, striker2 } };

            var game = new Game { Team1 = team1, Team2 = team2, Referee = referee, AssistantReferees = new List<AssistantReferee>(), Goals = new List<Goal>() };

            var goal = new Goal { Minute = 32, Player = striker1 };
            game.Goals.Add(goal);

            game.Result = "2-1";
            game.Winner = game.Team1;

            Console.WriteLine("Game Result: {0}", game.Result);
            Console.WriteLine("Winner: {0}", game.Winner);
            Console.WriteLine("Goals:");
            foreach (var g in game.Goals)
            {
                Console.WriteLine("{0} minute - {1} scored by {2}", g.Minute, g.Player.GetType().Name, g.Player.Name);
            }
        }
    }
}
