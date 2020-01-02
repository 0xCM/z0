//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class gmathops
    {
        public static bit even_d8i(sbyte x)
            => zfunc.even(x);

        public static bit even_g8i(sbyte x)
            => gmath.even(x);

        public static bit even_d8u(byte x)
            => zfunc.even(x);

        public static bit even_g8u(byte x)
            => gmath.even(x);

        public static bit even_d16i(short x)
            => zfunc.even(x);

        public static bit even_g16i(short x)
            => gmath.even(x);

        public static bit even_d16u(ushort x)
            => zfunc.even(x);

        public static bit even_g16u(ushort x)
            => gmath.even(x);

        public static bit even_d32i(int x)
            => zfunc.even(x);

        public static bit even_g32i(int x)
            => gmath.even(x);

        public static bit even_d32u(uint x)
            => zfunc.even(x);

        public static bit even_g32u(uint x)
            => gmath.even(x);

        public static bit even_d64i(long x)
            => zfunc.even(x);

        public static bit even_g64i(long x)
            => gmath.even(x);

        public static bit even_d64u(ulong x)
            => zfunc.even(x);

        public static bit even_g64u(ulong x)
            => gmath.even(x);

        public static bit odd_d8i(sbyte x)
            => zfunc.odd(x);

        public static bit odd_g8i(sbyte x)
            => gmath.odd(x);

        public static bit odd_d8u(byte x)
            => zfunc.odd(x);

        public static bit odd_g8u(byte x)
            => gmath.odd(x);

        public static bit odd_d16i(short x)
            => zfunc.odd(x);

        public static bit odd_g16i(short x)
            => gmath.odd(x);

        public static bit odd_d16u(ushort x)
            => zfunc.odd(x);

        public static bit odd_g16u(ushort x)
            => gmath.odd(x);

        public static bit odd_d32i(int x)
            => zfunc.odd(x);

        public static bit odd_g32i(int x)
            => gmath.odd(x);

        public static bit odd_d32u(uint x)
            => zfunc.odd(x);

        public static bit odd_g32u(uint x)
            => gmath.odd(x);

        public static bit odd_d64i(long x)
            => zfunc.odd(x);

        public static bit odd_g64i(long x)
            => gmath.odd(x);

        public static bit odd_d64u(ulong x)
            => zfunc.odd(x);

        public static bit odd_g64u(ulong x)
            => gmath.odd(x);
    }
}