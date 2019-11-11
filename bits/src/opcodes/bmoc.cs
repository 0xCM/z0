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
    
        public static ref BitMatrix8 transpose_8x8(in BitMatrix8 A, ref BitMatrix8 Z)
            => ref BitMatrix.transpose(A, ref Z);

        [MethodImpl(Inline)]
        public static ref BitMatrix<byte> and_g8x8(in BitMatrix<byte> A, in BitMatrix<byte> B, ref BitMatrix<byte> C)
            => ref BitMatrix.and(A, B,ref C);

        [MethodImpl(Inline)]
        public static ref BitMatrix<ushort> and_g16x16(in BitMatrix<ushort> A, in BitMatrix<ushort> B, ref BitMatrix<ushort> C)
            => ref BitMatrix.and(A,B,ref C);


        [MethodImpl(Inline)]
        public static ref BitMatrix<uint> and_g32x32(in BitMatrix<uint> A, in BitMatrix<uint> B, ref BitMatrix<uint> C)
            => ref BitMatrix.and(A,B, ref C);


        [MethodImpl(Inline)]
        public static ref BitMatrix<ulong> and_g64x64(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
            => ref BitMatrix.and(A, B, ref C);    


    }

}