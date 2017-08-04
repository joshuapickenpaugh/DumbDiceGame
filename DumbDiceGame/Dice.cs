using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumbDiceGame
{
    class Dice
    {
        private int _dice1;
        public int Dice1
        {
            get { return _dice1; }
            set { _dice1 = value; }
        }

        private int _dice2;
        public int Dice2
        {
            get { return _dice2; }
            set { _dice2 = value; }
        }

        public Dice()
        {
            RollDice();
        }

        public void RollDice()
        {
            Random rndNum = new Random();
            Dice1 = rndNum.Next();
        }
    }
}
