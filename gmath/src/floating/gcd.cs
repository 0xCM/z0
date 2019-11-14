//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class fmath
    {
        public static float gcd(float a, float b)
        {
            var x = abs(a);
            var y = abs(b);
            while (y != 0)
            {
                var rem = mod(x,y);
                x = y;
                y = rem;
            }

            return x;
        }

        public static double gcd(double a, double b)
        {
            var x = abs(a);
            var y = abs(b);
            while (y != 0)
            {
                var rem = mod(x,y);
                x = y;
                y = rem;
            }

            return x;
        } 
    }
}