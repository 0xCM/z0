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
 
    using static zfunc;
    using static As;

    /// <summary>
    /// Opcodes for bitmatrix operations
    /// </summary>
    public static class bmoc
    {        
        public static BitVector16 bm_16x4_col_literal(in BitMatrix16x4 A)
            => A.Col(2);

        public static BitVector8 bm_8x8_col_literal(in BitMatrix8 A)
            => A.Col(2);

        public static BitVector16 bm_16x4_col_index(in BitMatrix16x4 A, int index)
            => A.Col(index);

        public static void transpose_8x8_1(in BitMatrix8 A, ref BitMatrix8 Z)
            => BitMatrix.transpose_v1(A, ref Z);

        public static void transpose_8x8_2(in BitMatrix8 A, ref BitMatrix8 Z)
            => BitMatrix.transpose_v2(A, ref Z);

        public static void transpose_8x8_3(in BitMatrix8 A, ref BitMatrix8 Z)
            => BitMatrix.transpose_v3(A,ref Z);

        public static void transpose_8x8_4(in BitMatrix8 A, ref BitMatrix8 Z)
            => BitMatrix.transpose_v4(A, ref Z);

        public static BitMatrix4x16 transpose_16x4(in BitMatrix16x4 A)
            => BitMatrix.transpose(A);

        public static BitMatrix4 pbm_and_4x4(in BitMatrix4 A, in BitMatrix4 B)
            => BitMatrix.and(A, B);

        public static void pbm_and_8x8(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
            => BitMatrix.and(A, B, ref Z);

        public static  void gbm_and_8x8(in BitMatrix<byte> A, in BitMatrix<byte> B, ref BitMatrix<byte> Z)
            => BitMatrix.and(A, B,ref Z);

        public static void pbm_and_16x16(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
            => BitMatrix.and(A, B, ref Z);

        public static void gbm_and_16x16(in BitMatrix<ushort> A, in BitMatrix<ushort> B, ref BitMatrix<ushort> Z)
            => BitMatrix.and(A,B,ref Z);

        public static void pbm_and_32x32(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
            => BitMatrix.and(A, B, ref Z);

        public static void gbm_and_32x32(in BitMatrix<uint> A, in BitMatrix<uint> B, ref BitMatrix<uint> Z)
            => BitMatrix.and(A,B, ref Z);

        public static void pbm_and_64x64(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
            => BitMatrix.and(A, B, ref Z);

        public static void gbm_and_64x64(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> Z)
            => BitMatrix.and(A, B, ref Z);    

    }

}