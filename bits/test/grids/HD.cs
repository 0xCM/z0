//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// This class contains random algorithms from the book "Hackers Delight"
    /// </summary>
    public static class HD
    {
        public static uint compress(uint x, uint m) 
        {
            uint mk, mp, mv, t;
            int i;

            x = x & m;           // Clear irrelevant bits.
            mk = ~m << 1;        // We will count 0's to right.

            for (i = 0; i < 5; i++) 
            {
                mp = mk ^ (mk << 1);              // Parallel suffix.
                mp = mp ^ (mp << 2);
                mp = mp ^ (mp << 4);
                mp = mp ^ (mp << 8);
                mp = mp ^ (mp << 16);
                mv = mp & m;                      // Bits to move.
                m = m ^ mv | (mv >> (1 << i));    // Compress m.
                t = x & mv;
                x = x ^ t | (t >> (1 << i));      // Compress x.
                mk = mk & ~mp;
            }
            return x;
        }

        public static uint compress_left(uint x, uint m) 
        {
            uint mk, mp, mv, t;
            int i;

            x = x & m;           // Clear irrelevant bits.
            mk = ~m >> 1;        // We will count 0's to left.

            for (i = 0; i < 5; i++) 
            {
                mp = mk ^ (mk >> 1);              // Parallel prefix.
                mp = mp ^ (mp >> 2);
                mp = mp ^ (mp >> 4);
                mp = mp ^ (mp >> 8);
                mp = mp ^ (mp >> 16);
                mv = mp & m;                      // Bits to move.
                m = m ^ mv | (mv << (1 << i));    // Compress m.
                t = x & mv;
                x = x ^ t | (t << (1 << i));      // Compress x.
                mk = mk & ~mp;
            }
            return x;
        }

        public static uint SAG(uint x, uint m)         
            => compress_left(x, m) | compress(x, ~m);
    }
}

