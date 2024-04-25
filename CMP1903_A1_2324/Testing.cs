using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Object_Oriented_Programming_Assignment_2
{
    class Testing
    {
        static void Main(string[] args)
        {
            SevensOut SevensOutGame = new SevensOut();
            ThreeOrMore ThreeOrMoreGame = new ThreeOrMore();
            Statistics ShowStatistics = new Statistics();
            int SevensOutPlayed = 0;
            int ThreeOrMorePlayed = 0;
            Game Play = new Game();
            bool PlayTime = true;
            int TestDiceSum = Play.GetDiceRolls();
            Die DieRoll = new Die();
            Debug.Assert(TestDiceSum >= 3 && TestDiceSum <= 18, "The sum is an invalid result, out of range.");
            for (int i = 0; i < 50; i++)
            {
                int TestRolls = DieRoll.Roll();
                Debug.Assert(TestRolls >= 1 && TestRolls <= 6, "A die has given an invalid result, The dice's range isn't correct.");
            }
            int SevensOutScore = 0;
            int ThreeOrMoreScore = 0;
            while (PlayTime == true)
            {
                
                Console.WriteLine("Would you like to play a dice game? Please type either SevensOut or ThreeOrMore. If you do not wish to play a game, type anything else. You can check your statistics by typing Statistics.");
                string GamePlayed = Console.ReadLine();
                if (GamePlayed == "SevensOut")
                {
                    SevensOutScore = SevensOutGame.PlaySevensOut();
                    SevensOutPlayed++;
                }
                else if (GamePlayed == "ThreeOrMore")
                {
                    ThreeOrMoreScore = ThreeOrMoreGame.PlayThreeOrMore();
                    ThreeOrMorePlayed++;
                }
                else if (GamePlayed == "Statistics")
                { ShowStatistics.ShowStats(SevensOutPlayed, ThreeOrMorePlayed, SevensOutScore, ThreeOrMoreScore); }
                else
                { return; }
            }
        }
    }
