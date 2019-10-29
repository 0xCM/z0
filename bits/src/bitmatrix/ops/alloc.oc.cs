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

        public static BitMatrix8 bm_transpose_8x8(BitMatrix8 A, ref BitMatrix8 Z)
            => BitMatrix.transpose(A, ref Z);

        public static BitMatrix<byte> alloc_8x8u()
            => BitMatrix.alloc<byte>();

        public static BitMatrix<ushort> alloc_16x16u()
            => BitMatrix.alloc<ushort>();

        public static BitMatrix<uint> alloc_32x32u()
            => BitMatrix.alloc<uint>();

        public static BitMatrix<ulong> alloc_g64x64u()
            => BitMatrix.alloc<ulong>();

    }

}