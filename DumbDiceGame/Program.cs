//Joshua Pickenpaugh
//August 4th, 2017
//Dumb Dice

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumbDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice Dice = new Dice();

            Console.Write("Roll dice? Y or N: ");
            char chrUserSel = Convert.ToChar(Console.ReadLine());

            if (chrUserSel == 'Y' || chrUserSel == 'y')
            {
                Dice.RollDice();
            }

        }


    }
}
