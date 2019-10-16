//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;


    partial class zfoc
    {
        public static uint mul_lo_32u(uint x, uint y)
            => MulOps.lo(x,y);

        public static ulong mul_lo_64u(ulong x, ulong y)
            => MulOps.lo(x,y);

        public static uint mul_hi_32u(uint x, uint y)
            => MulOps.hi(x,y);

        public static ulong mul_hi_64u(ulong x, ulong y)
            => MulOps.hi(x,y);

        public static void mul_full_32u(uint a, uint b, out uint lo, out uint hi)
            => MulOps.full(a,b, out lo, out hi);

        public static void mul_full_64u(ulong x, ulong y, out ulong lo, out ulong hi)
            => MulOps.full(x,y, out lo, out hi);


    }


}