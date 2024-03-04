using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

public Testing(Game Play)
{
    Console.WriteLine("Below is a test game to verify that everything works as intended.");
    TestGame(Play);
}
public static void TestGame(Game Play)
{
    int TestDiceSum = Play.GetDiceRolls();
    Die DieRoll = new Die();
    Debug.Assert(TestDiceSum >= 3 && TestDiceSum <= 18, "The sum is an invalid result, out of range.");
    for (int i = 0; i < 50; i++)
    {
        int TestRolls = DieRoll.Roll();
        Debug.Assert(TestRolls >= 1 && TestRolls <= 6, "A die has given an invalid result, The dice's range isn't correct.");
    }
    Console.ReadLine();
}
    }
}
