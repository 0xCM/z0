//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class pmoc
    {
        public static bool nonzero_d8i(sbyte x)
            => !x.Equals(0);

        public static bit nonzero_g8i(sbyte x)
            => gmath.nonzero(x);

        public static bool nonzero_d8u(byte x)
            => !x.Equals(0);

        public static bit nonzero_g8u(byte x)
            => gmath.nonzero(x);

        public static bool nonzero_d16i(short x)
            => !x.Equals(0);

        public static bit nonzero_g16i(short x)
            => gmath.nonzero(x);

        public static bool nonzero_d16u(ushort x)
            => !x.Equals(0);

        public static bit nonzero_g16u(ushort x)
            => gmath.nonzero(x);

        public static bool nonzero_d32i(int x)
            => !x.Equals(0);

        public static bit nonzero_g32i(int x)
            => gmath.nonzero(x);

        public static bool nonzero_d32u(uint x)
            => !x.Equals(0);

        public static bit nonzero_g32u(uint x)
            => gmath.nonzero(x);

        public static bool nonzero_d64i(long x)
            => !x.Equals(0);

        public static bit nonzero_g64i(long x)
            => gmath.nonzero(x);

        public static bool nonzero_n64u(ulong x)
            => !x.Equals(0);

        public static bit nonzero_g64u(ulong x)
            => gmath.nonzero(x);
    }
}