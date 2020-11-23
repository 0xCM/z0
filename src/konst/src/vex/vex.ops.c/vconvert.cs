//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;
    using static z;

    partial struct z
    {
        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Zero extend 8 packed 8-bit integers in the low 8 bytes of xmm2/m64 to 8 packed 32-bit integers in ymm1
        /// </summary>
        /// <param name="n64">The number of bits covered by the source reference</param>
        /// <param name="src">The source reference</param>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert(N64 n64, in byte src, N256 w, N32 n)
            => v32u(ConvertToVector256Int32(gptr(src)));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Evenly covers a 256-bit target vector with a 64-bit source
        /// </summary>
        /// <param name="n64">The number of bits covered by the source reference</param>
        /// <param name="src">The source reference</param>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert(N64 n64, in ushort src, N256 w, N32 n)
            => v32u(ConvertToVector256Int32(gptr(u8(src))));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Evenly covers a 256-bit target vector with a 64-bit source
        /// </summary>
        /// <param name="n64">The number of bits covered by the source reference</param>
        /// <param name="src">The source reference</param>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert(N64 n64, in uint src, N256 w, N32 n)
            => v32u(ConvertToVector256Int32(gptr(u8(src))));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// Evenly covers a 256-bit target vector with a 64-bit source
        /// </summary>
        /// <param name="n64">The number of bits covered by the source reference</param>
        /// <param name="src">The source reference</param>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The target component width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert(N64 n64, in ulong src, N256 w, N32 n)
            => v32u(ConvertToVector256Int32(gptr(u8(src))));
    }
}