//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
 
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;
    using static As;

    partial class bmoc
    {
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<byte> and_bm8x8u(in BitMatrix<byte> A, in BitMatrix<byte> B, ref BitMatrix<byte> C)
            => ref BitMatrix.and(A, B,ref C);

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<byte> andg_bm8x8u(in BitMatrix<byte> A, in BitMatrix<byte> B, ref BitMatrix<byte> C)
            => ref BitMatrix.and<byte>(A, B,ref C);

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<ushort> and_bm16x16u(in BitMatrix<ushort> A, in BitMatrix<ushort> B, ref BitMatrix<ushort> C)
            => ref BitMatrix.and(A,B,ref C);

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<ushort> andg_bm16x16u(in BitMatrix<ushort> A, in BitMatrix<ushort> B, ref BitMatrix<ushort> C)
            => ref BitMatrix.and<ushort>(A, B, ref C);

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<uint> and_bm32x32u(in BitMatrix<uint> A, in BitMatrix<uint> B, ref BitMatrix<uint> C)
            => ref BitMatrix.and(A,B, ref C);

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<uint> andg_bm32x32u(in BitMatrix<uint> A, in BitMatrix<uint> B, ref BitMatrix<uint> C)
            => ref BitMatrix.and<uint>(A, B, ref C);

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<ulong> and_bm64x64u(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
            => ref BitMatrix.and(A, B, ref C);

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<ulong> andg_bm64x64u(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
            => ref BitMatrix.and<ulong>(A, B, ref C);

    }

}