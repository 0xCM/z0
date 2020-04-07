//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte gcd(sbyte a, sbyte b)
        {
            var x = math.abs(a);
            var y = math.abs(b);
            while (y != 0)
            {
                var rem = math.mod(x,y);
                x = y;
                y = rem;
            }
            return x;
        }

        [MethodImpl(Inline)]
        public static byte gcd(byte a, byte b)
        {
            while (b != 0)
            {
                var rem = math.mod(a,b);
                a = b;
                b = rem;
            }
            return a;
        }

        [MethodImpl(Inline)]
        public static short gcd(short a, short b)
        {
            var x = math.abs(a);
            var y = math.abs(b);
            while (y != 0)
            {
                var rem = math.mod(x,y);
                x = y;
                y = rem;
            }
            return x;
        }

        [MethodImpl(Inline)]
        public static ushort gcd(ushort a, ushort b)
        {
            while (b != 0)
            {
                var rem = math.mod(a,b);
                a = b;
                b = rem;
            }
            return a;
        }

        [MethodImpl(Inline)]
        public static int gcd(int a, int b)
        {
            var x = math.abs(a);
            var y = math.abs(b);
            while (y != 0)
            {
                var rem = math.mod(x,y);
                x = y;
                y = rem;
            }

            return x;
        }

        [MethodImpl(Inline)]
        public static uint gcd(uint a, uint b)
        {
            while (b != 0)
            {
                var rem = a % b;
                a = b;
                b = rem;
            }

            return a;
        }

        [MethodImpl(Inline)]
        public static long gcd(long a, long b)
        {
            var x = math.abs(a);
            var y = math.abs(b);
            while (y != 0)
            {
                var rem = math.mod(x,y);
                x = y;
                y = rem;
            }

            return x;
        }

        [MethodImpl(Inline)]
        public static ulong gcd(ulong a, ulong b)
        {
            while (b != 0)
            {
                var rem = a % b;
                a = b;
                b = rem;
            }

            return a;
        }
    }
}