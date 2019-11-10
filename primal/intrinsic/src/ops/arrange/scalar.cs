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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;    
    
    using static zfunc;

    partial class dinx    
    {        
        
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> scalar(int src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> scalar(uint src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<long> scalar(long src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> scalar(ulong src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<float> scalar(float src)
             => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<double> scalar(double src)
             => LoadScalarVector128(&src);

    }

}