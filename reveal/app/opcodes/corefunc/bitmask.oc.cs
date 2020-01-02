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
        public static ushort lsb12x2x1()
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