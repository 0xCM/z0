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

        public static BitVector32 bitrange_32_a(BitVector32 src, int i, int j)
            => src[i,j];



    }

}