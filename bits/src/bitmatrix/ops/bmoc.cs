//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
 
    using static zfunc;
    using static As;

    partial class bmoc
    {

        public static BitMatrix64 bm_from_natspan_64x64x64u(in Span<N64,ulong> src)
            => BitMatrix64.From(src);
    
        [MethodImpl(Inline)]
        public static ref BitMatrix<byte> gbm_and_8x8(in BitMatrix<byte> A, in BitMatrix<byte> B, ref BitMatrix<byte> C)
            => ref BitMatrix.and(A, B,ref C);


        [MethodImpl(Inline)]
        public static ref BitMatrix<ushort> gbm_and_16x16(in BitMatrix<ushort> A, in BitMatrix<ushort> B, ref BitMatrix<ushort> C)
            => ref BitMatrix.and(A,B,ref C);

        [MethodImpl(Inline)]
        public static BitMatrix<ushort> gbm_and_16x16_alloc(in BitMatrix<ushort> A, in BitMatrix<ushort> B)
            => BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static ref BitMatrix16 pbm_and_16x16(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 C)
            => ref BitMatrix.and(A,B,  ref C);

        [MethodImpl(Inline)]
        public static BitMatrix16 pbm_and_16x16_alloc(in BitMatrix16 A, in BitMatrix16 B)
            => BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static ref BitMatrix<uint> gbm_and_32x32(in BitMatrix<uint> A, in BitMatrix<uint> B, ref BitMatrix<uint> C)
            => ref BitMatrix.and(A,B, ref C);


        [MethodImpl(Inline)]
        public static ref BitMatrix<ulong> gbm_and_64x64(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
            => ref BitMatrix.and<ulong>(A, B, ref C);
    
    }

}