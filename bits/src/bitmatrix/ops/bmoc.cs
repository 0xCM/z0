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
        public static void bm_and_16x16u(BitMatrix16 A, BitMatrix16 B, BitMatrix16 C)
            => BitMatrix.and(A,B,C);

        public static void bm_and_32x32u(BitMatrix32 A, BitMatrix32 B, BitMatrix32 C)
            => BitMatrix.and(A,B,C);

        public static void bm_and_64x64u(BitMatrix64 A, BitMatrix64 B, BitMatrix64 C)
            => BitMatrix.and(A,B,C);

    }

}