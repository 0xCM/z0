//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {   
        //1000010000100001
        public static BitMatrix4 identity(N4 n) 
            => BitMatrix.primal(n,(ushort)0b1000010000100001);

        public static BitMatrix8 identity(N8 n) 
            => BitMatrix.primal(n,Identity8x8);

        public static BitMatrix16 identity(N16 n) 
            => BitMatrix.primal(n,Identity16x16);

        public static BitMatrix32 identity(N32 n) 
            => BitMatrix.primal(n,Identity32x32);

        public static BitMatrix64 identity(N64 n) 
            => BitMatrix.primal(n,Identity64x64);

        static ReadOnlySpan<byte> Identity4x4 => new byte[]
        {
            1 << 0, 
            1 << 1, 
            1 << 2, 
            1 << 3
        };

        static ReadOnlySpan<byte> Identity8x8 => new byte[]
        {
            1 << 0, 1 << 1, 1 << 2, 1 << 3, 1 << 4, 1 << 5, 1 << 6, 1 << 7
        };

        static ReadOnlySpan<byte> Identity16x16 => new byte[]
        {
            Pow2.T00, 0,
            Pow2.T01, 0,
            Pow2.T02, 0,
            Pow2.T03, 0,
            Pow2.T04, 0,
            Pow2.T05, 0,
            Pow2.T06, 0,
            Pow2.T07, 0,
            0, Pow2.T00,
            0, Pow2.T01,
            0, Pow2.T02,
            0, Pow2.T03,
            0, Pow2.T04,
            0, Pow2.T05,
            0, Pow2.T06,
            0, Pow2.T07,
        };
 
        static ReadOnlySpan<byte> Identity32x32 => new byte[]
        {
            Pow2.T00, 0, 0, 0,
            Pow2.T01, 0, 0, 0,
            Pow2.T02, 0, 0, 0,
            Pow2.T03, 0, 0, 0,
            Pow2.T04, 0, 0, 0,
            Pow2.T05, 0, 0, 0,
            Pow2.T06, 0, 0, 0,
            Pow2.T07, 0, 0, 0,
            0, Pow2.T00, 0, 0,
            0, Pow2.T01, 0, 0,
            0, Pow2.T02, 0, 0,
            0, Pow2.T03, 0, 0,
            0, Pow2.T04, 0, 0,
            0, Pow2.T05, 0, 0,
            0, Pow2.T06, 0, 0,
            0, Pow2.T07, 0, 0,
            0, 0, Pow2.T00, 0,
            0, 0, Pow2.T01, 0,
            0, 0, Pow2.T02, 0,
            0, 0, Pow2.T03, 0,
            0, 0, Pow2.T04, 0,
            0, 0, Pow2.T05, 0,
            0, 0, Pow2.T06, 0,
            0, 0, Pow2.T07, 0,
            0, 0, 0, Pow2.T00,
            0, 0, 0, Pow2.T01,
            0, 0, 0, Pow2.T02,
            0, 0, 0, Pow2.T03,
            0, 0, 0, Pow2.T04,
            0, 0, 0, Pow2.T05,
            0, 0, 0, Pow2.T06,
            0, 0, 0, Pow2.T07,
        };
 
         static ReadOnlySpan<byte> Identity64x64 => new byte[]
        {
            Pow2.T00, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T01, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T02, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T03, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T04, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T05, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T06, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T07, 0, 0, 0, 0, 0, 0, 0,
            0, Pow2.T00, 0, 0, 0, 0, 0, 0,
            0, Pow2.T01, 0, 0, 0, 0, 0, 0,
            0, Pow2.T02, 0, 0, 0, 0, 0, 0,
            0, Pow2.T03, 0, 0, 0, 0, 0, 0,
            0, Pow2.T04, 0, 0, 0, 0, 0, 0,
            0, Pow2.T05, 0, 0, 0, 0, 0, 0,
            0, Pow2.T06, 0, 0, 0, 0, 0, 0,
            0, Pow2.T07, 0, 0, 0, 0, 0, 0,
            0, 0, Pow2.T00, 0, 0, 0, 0, 0,
            0, 0, Pow2.T01, 0, 0, 0, 0, 0,
            0, 0, Pow2.T02, 0, 0, 0, 0, 0,
            0, 0, Pow2.T03, 0, 0, 0, 0, 0,
            0, 0, Pow2.T04, 0, 0, 0, 0, 0,
            0, 0, Pow2.T05, 0, 0, 0, 0, 0,
            0, 0, Pow2.T06, 0, 0, 0, 0, 0,
            0, 0, Pow2.T07, 0, 0, 0, 0, 0,
            0, 0, 0, Pow2.T00, 0, 0, 0, 0,
            0, 0, 0, Pow2.T01, 0, 0, 0, 0,
            0, 0, 0, Pow2.T02, 0, 0, 0, 0,
            0, 0, 0, Pow2.T03, 0, 0, 0, 0,
            0, 0, 0, Pow2.T04, 0, 0, 0, 0,
            0, 0, 0, Pow2.T05, 0, 0, 0, 0,
            0, 0, 0, Pow2.T06, 0, 0, 0, 0,
            0, 0, 0, Pow2.T07, 0, 0, 0, 0,
            0, 0, 0, 0, Pow2.T00, 0, 0, 0,
            0, 0, 0, 0, Pow2.T01, 0, 0, 0,
            0, 0, 0, 0, Pow2.T02, 0, 0, 0,
            0, 0, 0, 0, Pow2.T03, 0, 0, 0,
            0, 0, 0, 0, Pow2.T04, 0, 0, 0,
            0, 0, 0, 0, Pow2.T05, 0, 0, 0,
            0, 0, 0, 0, Pow2.T06, 0, 0, 0,
            0, 0, 0, 0, Pow2.T07, 0, 0, 0,
            0, 0, 0, 0, 0, Pow2.T00, 0, 0,
            0, 0, 0, 0, 0, Pow2.T01, 0, 0,
            0, 0, 0, 0, 0, Pow2.T02, 0, 0,
            0, 0, 0, 0, 0, Pow2.T03, 0, 0,
            0, 0, 0, 0, 0, Pow2.T04, 0, 0,
            0, 0, 0, 0, 0, Pow2.T05, 0, 0,
            0, 0, 0, 0, 0, Pow2.T06, 0, 0,
            0, 0, 0, 0, 0, Pow2.T07, 0, 0,
            0, 0, 0, 0, 0, 0, Pow2.T00, 0,
            0, 0, 0, 0, 0, 0, Pow2.T01, 0,
            0, 0, 0, 0, 0, 0, Pow2.T02, 0,
            0, 0, 0, 0, 0, 0, Pow2.T03, 0,
            0, 0, 0, 0, 0, 0, Pow2.T04, 0,
            0, 0, 0, 0, 0, 0, Pow2.T05, 0,
            0, 0, 0, 0, 0, 0, Pow2.T06, 0,
            0, 0, 0, 0, 0, 0, Pow2.T07, 0,
            0, 0, 0, 0, 0, 0, 0, Pow2.T00,
            0, 0, 0, 0, 0, 0, 0, Pow2.T01,
            0, 0, 0, 0, 0, 0, 0, Pow2.T02,
            0, 0, 0, 0, 0, 0, 0, Pow2.T03,
            0, 0, 0, 0, 0, 0, 0, Pow2.T04,
            0, 0, 0, 0, 0, 0, 0, Pow2.T05,
            0, 0, 0, 0, 0, 0, 0, Pow2.T06,
            0, 0, 0, 0, 0, 0, 0, Pow2.T07,
        };
    }
}