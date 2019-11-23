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
        public static BitMatrix4x16 transpose_16x4(in BitMatrix16x4 A)
            => BitMatrix.transpose(A);

        public static BitMatrix4 and_4x4(in BitMatrix4 A, in BitMatrix4 B)
            => BitMatrix.and(A, B);

        public static BitMatrix8 and_8x8(in BitMatrix8 A, in BitMatrix8 B)
            => BitMatrix.and(A, B);

        public static BitMatrix<byte> and_8x8g(in BitMatrix<byte> A, in BitMatrix<byte> B)
            => BitMatrix.and(A, B);

        public static ref BitMatrix8 and_8x8_ref(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
            => ref BitMatrix.and(A, B, ref Z);

        public static ref BitMatrix<byte> and_8x8g_ref(in BitMatrix<byte> A, in BitMatrix<byte> B, ref BitMatrix<byte> C)
            => ref BitMatrix.and(A, B,ref C);

        public static BitMatrix16 and_16x16(in BitMatrix16 A, in BitMatrix16 B)
            => BitMatrix.and(A, B);

        public static ref BitMatrix<ushort> and_16x16g_ref(in BitMatrix<ushort> A, in BitMatrix<ushort> B, ref BitMatrix<ushort> C)
            => ref BitMatrix.and(A,B,ref C);

        public static BitMatrix32 and_32x32(in BitMatrix32 A, in BitMatrix32 B)
            => BitMatrix.and(A, B);

        public static BitMatrix<uint> and_32x32g(in BitMatrix<uint> A, in BitMatrix<uint> B)
            => BitMatrix.and(A,B);

        public static ref BitMatrix32 and_32x32_ref(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
            => ref BitMatrix.and(A, B, ref Z);

        public static ref BitMatrix<uint> and_32x32g_ref(in BitMatrix<uint> A, in BitMatrix<uint> B, ref BitMatrix<uint> C)
            => ref BitMatrix.and(A, B,ref C);

        public static ref BitMatrix<ulong> and_64x64g_ref(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
            => ref BitMatrix.and(A, B, ref C);    

        public static ref BitMatrix8 transpose_8x8_ref(in BitMatrix8 A, ref BitMatrix8 Z)
            => ref BitMatrix.transpose(A, ref Z);

    }

}