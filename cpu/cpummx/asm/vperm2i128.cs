//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static zfunc;
    using static Reg;
    
    partial class Asm
    {
        /// <summary>
        /// VPERM2I128 ymm, ymm, ymm/m256, imm8
        /// Blends the source vectors as directed by the control value
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="control"></param>
        /// <remarks>See https://www.felixcloutier.com/x86/vperm2i128</remarks>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vperm2i128(YMM a, YMM b, byte control)        
            => Permute2x128(vload<ulong>(ref a), vload<ulong>(ref b), control);

        [MethodImpl(Inline)]
        public static Vector256<ulong> vperm2i128(Vector256<ulong> a, Vector256<ulong> b, byte control)        
            => Permute2x128(a, b, control);

        /// <summary>
        /// VPERM2F128 ymm, ymm, ymm/m256, imm8
        /// Blends the source vectors as directed by the control value
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="control"></param>
        /// <remarks>See https://www.felixcloutier.com/x86/vperm2f128</remarks>
        [MethodImpl(Inline)]
        public static Vector256<double> vperm2f128(YMM a, YMM b, byte control)        
            => Permute2x128(vload<double>(ref a), vload<double>(ref b), control);

    }


}