//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class zfoc
    {

        public static bool testbit_d8i(sbyte src, int pos)
            => BitMask.test(src,pos);

        public static bool testbit_g8i(sbyte src, int pos)
            => BitMaskG.testbit(src,pos);

        public static bool testbit_d8u(byte src, int pos)
            => BitMask.test(src,pos);

        public static bool testbit_g8u(byte src, int pos)
            => BitMaskG.testbit(src,pos);

        public static bool testbit_d16i(short src, int pos)
            => BitMask.test(src,pos);

        public static bool testbit_g16i(short src, int pos)
            => BitMaskG.testbit(src,pos);

        public static bool testbit_d16u(ushort src, int pos)
            => BitMask.test(src,pos);

        public static bool testbit_g16u(ushort src, int pos)
            => BitMaskG.testbit(src,pos);

        public static bool testbit_d32i(int src, int pos)
            => BitMask.test(src,pos);

        public static bool testbit_g32i(int src, int pos)
            => BitMaskG.testbit(src,pos);

        public static bool testbit_d32u(uint src, int pos)
            => BitMask.test(src,pos);

        public static bool testbit_g32u(uint src, int pos)
            => BitMaskG.testbit(src,pos);

        public static bool testbit_d64i(long src, int pos)
            => BitMask.test(src,pos);

        public static bool testbit_g64i(long src, int pos)
            => BitMaskG.testbit(src,pos);
    
        public static bool testbit_d64u(ulong src, int pos)
            => BitMask.test(src,pos);

        public static bool testbit_g64u(ulong src, int pos)
            => BitMaskG.testbit(src,pos);

        public static bool testbit_d32f(float src, int pos)
            => BitMask.test(src,pos);

        public static bool testbit_g32f(float src, int pos)
            => BitMaskG.testbit(src,pos);

        public static bool testbit_d64f(double src, int pos)
            => BitMask.test(src,pos);

        public static bool testbit_g64f(double src, int pos)
            => BitMaskG.testbit(src,pos);
    }
}