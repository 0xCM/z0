//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;

    using static zfunc;

    [OpCodeProvider]
    public static class bitmask
    {            
        public static ulong central_64x8x4
            => BitMask.central(n8,n4,z64);

        public static byte index_8x8x0
            => BitMask.index(n0,z8);

        public static byte index_8x8x1
            => BitMask.index(n1,z8);

        public static byte index_8x8x2
            => BitMask.index(n2,z8);

        public static byte index_8x8x3
            => BitMask.index(n3,z8);

        public static byte index_8x8x4
            => BitMask.index(n4,z8);

        public static byte index_8x8x5
            => BitMask.index(n5,z8);

        public static byte index_8x8x6
            => BitMask.index(n6,z8);

        public static byte index_8x8x7
            => BitMask.index(n7,z8);


        public static uint index_32x8x0
            => BitMask.index(n0,z32);

        public static uint index_32x8x1
            => BitMask.index(n1,z32);

        public static uint index_32x8x2
            => BitMask.index(n2,z32);

        public static uint index_32x8x3
            => BitMask.index(n3,z32);

        public static uint index_32x8x4
            => BitMask.index(n4,z32);

        public static uint index_32x8x5
            => BitMask.index(n5,z32);

        public static uint index_32x8x6
            => BitMask.index(n6,z32);

        public static uint index_32x8x7
            => BitMask.index(n7,z32);


        public static ulong index_64x8x0
            => BitMask.index(n0,z64);

        public static ulong index_64x8x1
            => BitMask.index(n1,z64);

        public static ulong index_64x8x2
            => BitMask.index(n2,z64);

        public static ulong index_64x8x3
            => BitMask.index(n3,z64);

        public static ulong index_64x8x4
            => BitMask.index(n4,z64);

        public static ulong index_64x8x5
            => BitMask.index(n5,z64);

        public static ulong index_64x8x6
            => BitMask.index(n6,z64);

        public static ulong index_64x8x7
            => BitMask.index(n7,z64);

        public static uint msb_32x8x1
            => BitMask.msb(n8,n1,z32);

        public static ushort lsb12x2x1
            => BitMask.lsb(n12, n2, n1, z16);

        public static bit testbit_8i(sbyte src, int pos)
            => BitMask.testbit(src,pos);

        public static bit testbit_d8u(byte src, int pos)
            => BitMask.testbit(src,pos);

        public static bit testbit_8u(byte src, int pos)
            => BitMask.testbit(src,pos);

        public static bit testbit_16i(short src, int pos)
            => BitMask.testbit(src,pos);

        public static bit testbit_16u(ushort src, int pos)
            => BitMask.testbit(src,pos);

        public static bit testbit_32i(int src, int pos)
            => BitMask.testbit(src,pos);

        public static bit testbit_32u(uint src, int pos)
            => BitMask.testbit(src,pos);

        public static bit testbit_64i(long src, int pos)
            => BitMask.testbit(src,pos);
    
        public static bit testbit_64u(ulong src, int pos)
            => BitMask.testbit(src,pos);

        public static bit testbit_32f(float src, int pos)
            => BitMask.testbit(src,pos);

        public static bit testbit_64f(double src, int pos)
            => BitMask.testbit(src,pos); 

    }
}