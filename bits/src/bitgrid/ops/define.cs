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

    partial class BitGrid
    {                

        [MethodImpl(Inline)]
        public static BitGrid128<N8,N16,ushort> define(N128 bitcount, N8 m, N16 n, 
            ushort x0, ushort x1, ushort x2, ushort x3, ushort x4, ushort x5, ushort x6, ushort x7)
                => new BitGrid128<N8, N16, ushort>(DataBlocks.cells(n128, x0,x1,x2,x3,x4,x5,x6,x7));

        [MethodImpl(Inline)]
        public static BitGrid128<N16,N8,byte> define(N128 bitcount, N16 m, N8 n, 
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7,
            byte x8, byte x9, byte xA, byte xB, byte xC, byte xD, byte xE, byte xF)
                => new BitGrid128<N16, N8, byte>(DataBlocks.cells(n128, x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,xA,xB,xC,xD,xE,xF));

        [MethodImpl(Inline)]
        public static BitGrid128<N4,N32,uint> define(N128 bitcount, N4 m, N32 n, 
            uint x0, uint x1, uint x2, uint x3)
                => new BitGrid128<N4, N32, uint>(DataBlocks.cells(n128, x0,x1,x2,x3));

        [MethodImpl(Inline)]
        public static BitGrid128<N2,N64,ulong> define(N128 bitcount, N2 m, N64 n, ulong x0, ulong x1)
            => new BitGrid128<N2, N64, ulong>(DataBlocks.cells(n128, x0,x1));

    }

}