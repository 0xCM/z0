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

        public static (ulong lo, ulong hi) umul_128u(ulong lhs, ulong rhs)
            => UMul.mul(lhs, rhs);

        public static void umul_128u_out(ulong lhs, ulong rhs, out ulong lo, out ulong hi)
            => UMul.mul(lhs, rhs, out lo, out hi);

        public static ulong umul_64u(uint lhs, uint rhs)
            => UMul.mul(lhs,rhs);   

        public static ulong umul_64u_hi(ulong lhs, ulong rhs)
            => UMul.himul(lhs,rhs);

        public static ulong umul_64u_lo(ulong lhs, ulong rhs)
            => UMul.lomul(lhs,rhs);

    }


}