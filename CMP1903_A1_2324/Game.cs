using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        Die One = new Die();
Die Two = new Die();
Die Three = new Die();
public Game()
{
    GetDiceRolls();
}

public int GetDiceRolls()
{
    int one = One.Roll();
    int two = Two.Roll();
    int three = Three.Roll();
    Console.WriteLine(one);
    Console.WriteLine(two);
    Console.WriteLine(three);
    int sum = one + two + three;
    Console.WriteLine("The sum of the dice rolls is " + sum);
    return sum;
}

    }
}
