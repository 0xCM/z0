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

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
     
    using static zfunc;   
    using static AsIn;

    partial class dinx
    {                
 
        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Evenly covers a 256-bit target vector with a 64-bit source
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vconvert(N64 count, in byte src, N256 w, N32 n)
            => v32u(ConvertToVector256Int32(constptr(in src)));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Evenly covers a 256-bit target vector with a 64-bit source
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vconvert(N64 count, in ulong src, N256 w, N32 n)
            => v32u(ConvertToVector256Int32(constptr(in uint8(in src))));

    }

}