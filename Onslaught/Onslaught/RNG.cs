﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onslaught
{
    static class RNG
    {
        static Random random = new Random();

        

        public static int RandInt(int low, int high)
        {
            return random.Next(low, high + 1);
        }
    }
}
