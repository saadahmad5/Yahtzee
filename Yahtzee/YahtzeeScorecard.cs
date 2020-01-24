using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class YahtzeeScorecard
    {
        public int Ones { get; set; }
        public int Twos { get; set; }
        public int Threes { get; set; }
        public int Fours { get; set; }
        public int Fives { get; set; }
        public int Sixes { get; set; }
        //....

        public bool Bonus;
        public int ThreeOfKind { get; set; }
        public int FourOfKind { get; set; }
        public int FullHouse { get; set; }
        public int SmallStraight { get; set; }
        public int LargeStraight { get; set; }
        public int Chance { get; set; }
        public int YAHtzee { get; set; }

        public int Total { get; set; }

        public void refresh()
        {
            Total = Ones + Twos+ Threes + Fours + Fives + Sixes + ThreeOfKind + FourOfKind + 
                FullHouse + SmallStraight + LargeStraight + Chance + YAHtzee;
            if((Ones + Twos + Threes + Fours + Fives + Sixes) > 63)
            {
                if(Ones != 0 && Twos != 0 && Threes != 0 && Fours != 0 && Fives != 0 && Sixes != 0)
                {
                    Bonus = true;
                }
            }
            if(Bonus)
            {
                Total += 35;
            }
        }


        public YahtzeeScorecard()
        {
            Total = 0;
            Ones = 0;
            Twos = 0;
            Threes = 0;
            Fours = 0;
            Fives = 0;
            Sixes = 0;
            ThreeOfKind = 0;
            FourOfKind = 0;
            FullHouse = 0;
            SmallStraight = 0;
            LargeStraight = 0;
            Chance = 0;
            YAHtzee = 0;
            Bonus = false;
        }
    }
}
