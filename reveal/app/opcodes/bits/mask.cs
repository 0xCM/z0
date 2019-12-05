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
        public static uint max_val_nbv_4()
            => BitVector<N4,uint>.MaxValue;

        public static uint max_val_nbv_8()
            => BitVector<N8,uint>.MaxValue;

        public static BitVector<N8,uint> add(BitVector<N8,uint> x,BitVector<N8,uint> y)
            => x + y;

        public static BitVector<N8,uint> inc(BitVector<N8,uint> src)
            => ++src; 

        public static BitVector<N8,uint> dec(BitVector<N8,uint> src)
            => --src; 

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


        public static ulong clear_64(ulong src, int p0, int p1)
          => Bits.clear(src,p0,p1);

        public static ulong inject_64(ulong src, ulong dst, byte index, byte length)
              => Bits.inject(src,dst,index,length);

    }

}