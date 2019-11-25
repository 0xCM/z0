//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class bvoc
    {

        public static bit mod_prod_nbv(BitVector<N23,uint> x, BitVector<N23,uint> y)
            => BitVector.modprod(x,y);
        public static byte inject_8u(byte src,byte dst, int start, int len)
            => gbits.inject(src,dst,start,len);

        public static ushort inject_16u(ushort src,ushort dst, int start, int len)
            => gbits.inject(src,dst,start,len);

        public static uint inject_32u(uint src,uint dst, int start, int len)
            => gbits.inject(src,dst,start,len);


        public static ulong inject_64u(ulong src,ulong dst, int start, int len)
            => gbits.inject(src,dst,start,len);

        public static BitVector32 bitrange_32_a(BitVector32 src, int i, int j)
            => src[i,j];


        public static ulong mask_1x64u(ulong dst, int exp0)
            => Bits.mask(ref dst, exp0);        

        public static ulong mask_2x64u(ulong dst, int exp0, int exp1)
            => Bits.mask(ref dst, exp0, exp1);        

        public static ulong mask_3x64u(ulong dst, int exp0, int exp1, int exp2)
            => Bits.mask(ref dst, exp0, exp1, exp2);        

        public static ulong mask_4x64u(ulong dst, int exp0, int exp1, int exp2, int exp3)
            => Bits.mask(ref dst, exp0, exp1, exp2, exp3);        

        public static ulong mask_5x64u(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4)
            => Bits.mask(ref dst, exp0, exp1, exp2, exp3, exp4);        

        public static ulong mask_6x64u(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5)
            => Bits.mask(ref dst, exp0, exp1, exp2, exp3, exp4, exp5);        

        public static ulong mask_7x64u(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6)
            => Bits.mask(ref dst, exp0, exp1, exp2, exp3, exp4, exp5, exp6);        

        public static ulong mask_8x64u(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6, int exp7)
            => Bits.mask(ref dst, exp0, exp1, exp2, exp3, exp4, exp5, exp6, exp7);        

    }

}