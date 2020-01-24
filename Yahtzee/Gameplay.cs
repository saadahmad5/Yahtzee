using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class Gameplay
    {
        public IRandom Dice;
        public int numRolls;
        int[] Dices;
        public int[] selectRolls;
        public int[] currentScore;

        public Gameplay()
        {
            Dice = new RandomWrapper();
            initializeDices();
            selectRolls = new int[5];
            currentScore = new int[13];
            numRolls = 0;
        }

        public Gameplay(IRandom random)
        {
            Dice = random;
            initializeDices();
            selectRolls = new int[5];
            currentScore = new int[13];
            numRolls = 0;
        }

        public void initializeDices()
        {
            Dices = new int[5];
            for (int i = 0; i < 5; ++i)
            {
                Dices[i] = Dice.Next(1, 7);
            }
        }

        public int getDiceValue(int index)
        {
            return Dices[index];
        }

        public void setDiceValue(int index, int value)
        {
            selectRolls[index] = value;
        }

        public void scoreGenerator()
        {
            //currentScore = new int[13];
            //for (int i = 0; i < 13; ++i)
            //{
            //    currentScore[i] = 0;
            //}
            int count;
            // For Ones
            count = 0;
            for (int i = 0; i < 5; ++i)
            {
                if (selectRolls[i] == 1)
                {
                    count++;
                }
            }
            currentScore[0] = count * 1;
            // For Twos
            count = 0;
            for (int i = 0; i < 5; ++i)
            {
                if (selectRolls[i] == 2)
                {
                    count++;
                }
            }
            currentScore[1] = count * 2;
            // For Threes
            count = 0;
            for (int i = 0; i < 5; ++i)
            {
                if (selectRolls[i] == 3)
                {
                    count++;
                }
            }
            currentScore[2] = count * 3;
            // For Fours
            count = 0;
            for (int i = 0; i < 5; ++i)
            {
                if (selectRolls[i] == 4)
                {
                    count++;
                }
            }
            currentScore[3] = count * 4;
            // For Fives
            count = 0;
            for (int i = 0; i < 5; ++i)
            {
                if (selectRolls[i] == 5)
                {
                    count++;
                }
            }
            currentScore[4] = count * 5;
            // For Sixes
            count = 0;
            for (int i = 0; i < 5; ++i)
            {
                if (selectRolls[i] == 6)
                {
                    count++;
                }
            }
            currentScore[5] = count * 6;

            // ThreeOfKind
            for (int j = 1; j <= 6; ++j)
            {
                count = 0;
                for (int i = 0; i < 5; ++i)
                {
                    if (selectRolls[i] == j)
                    {
                        count++;
                    }
                }
                if (count >= 3)
                {
                    count = 0;
                    for (int i = 0; i < 5; ++i)
                    {
                        count += selectRolls[i];
                    }
                    currentScore[7] = count;
                    break;
                }

            }

            // FourOfKind
            for (int j = 1; j <= 6; ++j)
            {
                count = 0;
                for (int i = 0; i < 5; ++i)
                {
                    if (selectRolls[i] == j)
                    {
                        count++;
                    }
                }
                if (count >= 4)
                {
                    count = 0;
                    for (int i = 0; i < 5; ++i)
                    {
                        count += selectRolls[i];
                    }
                    currentScore[8] = count;
                    break;
                }

            }

            //Small Straight
            for (int i = 1; i <= 3; ++i)
            {
                if (have(i) && have(i + 1) && have(i + 2) && have(i + 3))
                {
                    currentScore[9] = 25;
                    break;
                }
            }

            //Large Straight
            for (int i = 1; i <= 2; ++i)
            {
                if (have(i) && have(i + 1) && have(i + 2) && have(i + 3) && have(i + 4))
                {
                    currentScore[10] = 40;
                    break;
                }
            }

            //Para Yahtzee FiveOfKind
            for (int j = 1; j <= 6; ++j)
            {
                count = 0;
                for (int i = 0; i < 5; ++i)
                {
                    if (selectRolls[i] == j)
                    {
                        count++;
                    }
                }
                if (count == 5)
                {
                    currentScore[12] = 50;
                    break;
                }

            }

            // For Chance
            count = 0;
            for (int i = 0; i < 5; ++i)
            {
                count += selectRolls[i];
            }
            currentScore[11] = count;

            // For Full House
            
            Array.Sort(selectRolls);

            if((((selectRolls[0] == selectRolls[1]) && (selectRolls[1] == selectRolls[2])) && 
                 (selectRolls[3] == selectRolls[4]) && 
                 (selectRolls[2] != selectRolls[3])) ||
                ((selectRolls[0] == selectRolls[1]) && 
                 ((selectRolls[2] == selectRolls[3]) && (selectRolls[3] == selectRolls[4])) && 
                 (selectRolls[1] != selectRolls[2])))
            {
                currentScore[6] = 25;
            }

        }

        private bool have(int diceNumber)
        {
            for (int i = 0; i < 5; ++i)
            {
                if (selectRolls[i] == diceNumber)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
