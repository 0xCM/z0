//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
     
    using static AsIn;
    using static Gone2;
    using static Seed; using static Memories;
    
    partial class dvec
    {                
        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Evenly covers a 256-bit target vector with a 64-bit source
        /// </summary>
        /// <param name="srcbits">The nuber of bits covered by the source reference</param>
        /// <param name="src">The source reference</param>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert(N64 srcbits, in byte src, N256 w, N32 n)
            => v32u(ConvertToVector256Int32(constptr(in src)));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Evenly covers a 256-bit target vector with a 64-bit source
        /// </summary>
        /// <param name="srcbits">The nuber of bits covered by the source reference</param>
        /// <param name="src">The source reference</param>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert(N64 srcbits, in ushort src, N256 w, N32 n)
            => v32u(ConvertToVector256Int32(constptr(in uint8(in src))));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Evenly covers a 256-bit target vector with a 64-bit source
        /// </summary>
        /// <param name="srcbits">The nuber of bits covered by the source reference</param>
        /// <param name="src">The source reference</param>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert(N64 srcbits, in uint src, N256 w, N32 n)
            => v32u(ConvertToVector256Int32(constptr(in uint8(in src))));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Evenly covers a 256-bit target vector with a 64-bit source
        /// </summary>
        /// <param name="srcbits">The nuber of bits covered by the source reference</param>
        /// <param name="src">The source reference</param>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert(N64 srcbits, in ulong src, N256 w, N32 n)
            => v32u(ConvertToVector256Int32(constptr(in uint8(in src))));
    }
}