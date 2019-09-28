//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;    

    partial class dfp
    {
        [MethodImpl(Inline)]
        public static Vec128<float> vadd(in Vec128<float> lhs, in Vec128<float> rhs)
            => Add(lhs.xmm, lhs.xmm);

        [MethodImpl(Inline)]
        public static Vec128<double> vadd(in Vec128<double> lhs, in Vec128<double> rhs)
            => Add(lhs.xmm, rhs.xmm);

        [MethodImpl(Inline)]
        public static Vec256<float> vadd(in Vec256<float> lhs, in Vec256<float> rhs)
            => Add(lhs.ymm, rhs.ymm);

        [MethodImpl(Inline)]
        public static Vec256<double> vadd(in Vec256<double> lhs, in Vec256<double> rhs)
            => Add(lhs.ymm, rhs.ymm);             

    }
}