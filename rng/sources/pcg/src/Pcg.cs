//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    static class Pcg
    {
        public const ulong DefaultMultiplier = 6364136223846793005;

        public const ulong DefaultIndex = 1442695040888963407;

        public static ulong advance(ulong state, ulong delta, ulong multiplier, ulong index)
        {
            ulong factor = 1u;
            ulong increment = 0u;
            while (delta > 0) 
            {
                if ((delta & 1)  != 0)
                {
                    factor *= multiplier;
                    increment = increment * multiplier + index;
                }
                index = (multiplier + 1) * index;
                multiplier *= multiplier;
                delta /= 2;
            }
            return factor * state + increment;
        }
    }
}