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
        public static BitMatrix8 Block(BitMatrix16 A, N0 r0, N0 c0)
        {
            var r1 = r0 + 8;
            var c1 = c0 + 8;
            var dst = new byte[8];
            for(int i=r0; i< r0; i++)                
                dst[i] = Bits.lo(A[i]);
            return BitMatrix8.From(dst);
        }

        public static BitMatrix8 Block(BitMatrix16 A, N0 r0, N7 c0)
        {
            var r1 = r0 + 8;
            var c1 = c0 + 8;
            var dst = new byte[8];
            for(int i=r0; i< r0; i++)                
                dst[i] = Bits.hi(A[i]);
            return BitMatrix8.From(dst);
        }

        public static BitMatrix8 Block(BitMatrix16 A, N7 r0, N0 c0)
        {
            var r1 = r0 + 8;
            var c1 = c0 + 8;
            var dst = new byte[8];
            for(int i=r0; i< r0; i++)                
                dst[i] = Bits.lo(A[i]);
            return BitMatrix8.From(dst);
        }

        public static BitMatrix8 Block(BitMatrix16 A, N7 r0, N7 c0)
        {
            var r1 = r0 + 8;
            var c1 = c0 + 8;
            var dst = new byte[8];
            for(int i=r0; i< r0; i++)                
                dst[i] = Bits.hi(A[i]);
            return BitMatrix8.From(dst);
        }



    }

}