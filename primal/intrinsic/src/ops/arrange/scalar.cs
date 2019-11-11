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
        public static unsafe Vector128<int> vscalar(int src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vscalar(uint src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vscalar(long src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vscalar(ulong src)
            => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<float> vscalar(float src)
             => LoadScalarVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<double> vscalar(double src)
             => LoadScalarVector128(&src);

    }

}