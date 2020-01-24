﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class RandomWrapper : IRandom
    {
        private Random random;

        public RandomWrapper()
        {
            random = new Random();
        }

        public int Next(int startingAtThisMin, int upToButNotIncludingThisMax)
        {
            return random.Next(startingAtThisMin, upToButNotIncludingThisMax);
        }


    }
}
