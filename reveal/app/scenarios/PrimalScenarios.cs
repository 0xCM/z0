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
    using System.Runtime.Intrinsics;
    using System.IO;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;

    class PrimalScenarios : Deconstructable<PrimalScenarios>
    {
        public PrimalScenarios()
            : base(callerfile())
        {

        }

        public static int polyadd_int32(int x, int y)
            => StructOps.add(x,y);
        public static ulong min_n64u(ulong x, ulong y)
            => Math.Min(x,y);

        public static ulong min_d64u(ulong x, ulong y)
            => math.min(x,y);

        public static ulong min_g64u(ulong x, ulong y)
            => gmath.min(x,y);

        public static long abs_n64i(long x)
            => Math.Abs(x);

        public static long abs_d64i(long x)
            => math.abs(x);

        public static long abs_g64i(long x)
            => gmath.abs(x);

        public static long negate_n64i(long x)
            => -x;

        public static long negate_g64i(long x)
            => gmath.negate(x);

        public static long negate_d64i(long x)
            => math.negate(x);

        public static ulong negate_g64u(ulong x)
            => gmath.negate(x);

        public static ulong negate_d64i(ulong x)
            => math.negate(x);

        public static ulong add_n64u(ulong x, ulong y)
            => x + y;

        public static ulong add_d64u(ulong x, ulong y)
            => math.add(x,y);

        public static ulong add_g64u(ulong x, ulong y)
            => gmath.add(x,y);

        public static ulong div_n64u(ulong x, ulong y)
            => x/y;

        public static ulong div_d64u(ulong x, ulong y)
            => math.div(x,y);

        public static ulong div_g64u(ulong x, ulong y)
            => gmath.div(x,y);

        public static ulong mod_n64u(ulong x, ulong y)
            => x % y;

        public static ulong mod_d64u(ulong x, ulong y)
            => math.mod(x,y);

        public static ulong mod_g64u(ulong x, ulong y)
            => gmath.mod(x,y);

        public static ulong inc_n64u(ulong x)
            => ++x;

        public static ulong inc_d64u(ulong x)
            => math.inc(x);

        public static ulong inc_g64u(ulong x)
            => gmath.inc(x);

        public static bool gt_n64u(ulong x, ulong y)
            => x > y;

        public static bool gt_d64u(ulong x, ulong y)
            => math.gt(x,y);

        public static bool gt_g64u(ulong x, ulong y)
            => gmath.gt(x,y);
        
        public static bool gteq_n64u(ulong x, ulong y)
            => x >= y;
        
        public static bool gteq_d64u(ulong x, ulong y)
            => math.gteq(x,y);

        public static bool gteq_g64u(ulong x, ulong y)
            => gmath.gteq(x,y);

        public static bool eq_n64u(ulong x, ulong y)
            => x == y;

        public static bool eq_d64u(ulong x, ulong y)
            => math.eq(x,y);

        public static bool eq_g64u(ulong x, ulong y)
            => gmath.eq(x,y);

        public static ulong mul_n64u(ulong x, ulong y)
            => x * y;

        public static ulong mul_d64u(ulong x, ulong y)
            => math.mul(x,y);

        public static ulong mul_g64u(ulong x, ulong y)
            => gmath.mul(x,y);        

        public static ulong and_n64u(ulong x, ulong y)
            => x & y;

        public static ulong and_d64u(ulong x, ulong y)
            => math.and(x,y);

        public static ulong and_g64u(ulong x, ulong y)
            => gmath.and(x,y);

        public static ulong or_n64u(ulong x, ulong y)
            => x | y;

        public static ulong or_d64u(ulong x, ulong y)
            => math.or(x,y);

        public static ulong or_g64u(ulong x, ulong y)
            => gmath.or(x,y);

        public static ulong xor_n64u(ulong x, ulong y)
            => x ^ y;

        public static ulong xor_d64u(ulong x, ulong y)
            => math.xor(x,y);

        public static ulong xor_g64u(ulong x, ulong y)
            => gmath.xor(x,y);


 
    }
}