//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zfunc;

    class PrimalScenarios : Deconstructable<PrimalScenarios>
    {
        public PrimalScenarios()
            : base(callerfile())
        {

        }

        public static ulong div_64u(ulong x, ulong y)
            => x/y;

        public static ulong div_g64u(ulong x, ulong y)
            => gmath.div(x,y);
        
        public static ulong inc_64u(ulong x)
            => ++x;

        public static ulong inc_g64u(ulong x)
            => gmath.inc(x);

        public static ref ulong inc_g64u_ref(ref ulong x)
            => ref gmath.inc(ref x);

        public static ref ulong inc_64u_ref(ref ulong x)
            => ref math.inc(ref x);

        public static bool gt_64u(ulong x, ulong y)
            => x > y;

        public static bool gt_g64u(ulong x, ulong y)
            => gmath.gt(x,y);

        public static bool gteq_64u(ulong x, ulong y)
            => x >= y;

        public static bool gteq_g64u(ulong x, ulong y)
            => gmath.gteq(x,y);

        public static bool eq_64u(ulong x, ulong y)
            => x == y;

        public static bool eq_g64u(ulong x, ulong y)
            => gmath.eq(x,y);

        public static byte add_8u(byte x, byte y)
            => (byte)(x + y);

        public static byte add_g8u(byte x, byte y)
            => gmath.add(x,y);
        
        public static ulong mul_64u(ulong x, ulong y)
            => x * y;

        public static ulong mul_g64u(ulong x, ulong y)
            => gmath.mul(x,y);

        public static byte mul_8u(byte x, byte y)
            => (byte)(x * y);

        public static byte mul_g8u(byte x, byte y)
            => gmath.mul(x,y);

        public static ulong and_64u(ulong x, ulong y)
            => x & y;

        public static ulong and_g64u(ulong x, ulong y)
            => gmath.and(x,y);

        public static ulong mod_64u(ulong x, ulong y)
            => x % y;

        public static ulong mod_g64u(ulong x, ulong y)
            => gmath.mod(x,y);

        public static long abs_64i(long x)
            => math.abs(x);

        public static long abs_g64i(long x)
            => gmath.abs(x);

        public static ulong or_64u(ulong x, ulong y)
            => x | y;

        public static ulong or_g64u(ulong x, ulong y)
            => gmath.or(x,y);

        public static ulong xor_64u(ulong x, ulong y)
            => x ^ y;

        public static ulong xor_g64u(ulong x, ulong y)
            => gmath.xor(x,y);

        public static bool gteq_32i(int x, int y)
            => x == y;

        public static bool gteq_g32i(int x, int y)
            => gmath.gteq(x,y);

 
    }
}