//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class bvoc
    {
        public static BitVector32 and_bv_32u(BitVector32 x, BitVector32 y)
            => bitvector.and(x,y);

        public static BitVector32 and_bv_o32u(BitVector32 x, BitVector32 y)
            => x & y;

        public static BitVector32 and_bv_g32u(BitVector32 x, BitVector32 y)
            => gbv.and(x,y);
        
        public static BitVector32 or_bv_32u(BitVector32 x, BitVector32 y)
            => bitvector.or(x,y);

        public static BitVector32 or_bv_o32u(BitVector32 x, BitVector32 y)
            => x | y;

        public static BitVector32 or_bv_g32u(BitVector32 x, BitVector32 y)
            => gbv.or(x,y);
        
        public static BitVector32 xor_bv_32u(BitVector32 x, BitVector32 y)
            => bitvector.xor(x,y);

        public static BitVector32 xor_bv_o32u(BitVector32 x, BitVector32 y)
            => x ^ y;

        public static BitVector32 xor_bv_g32u(BitVector32 x, BitVector32 y)
            => gbv.xor(x,y);

        public static BitVector32 sll_bv_32u(BitVector32 x, int offset)
            => bitvector.sll(x,offset);

        public static BitVector32 sll_bv_o32u(BitVector32 x, int offset)
            => x << offset;

        public static BitVector32 sll_bv_g32u(BitVector32 x, int offset)
            => gbv.sll(x,offset);
        
        public static BitVector32 srl_bv_32u(BitVector32 x, int offset)
            => bitvector.srl(x,offset);

        public static BitVector32 srl_bv_o32u(BitVector32 x, int offset)
            => x >> offset;

        public static BitVector32 srl_bv_g32u(BitVector32 x, int offset)
            => gbv.srl(x,offset);

        public static BitVector32 flip_bv_32u(BitVector32 x)
            => bitvector.not(x);

        public static BitVector32 flip_bv_o32u(BitVector32 x)
            => ~x;

        public static BitVector32 flip_bv_g32u(BitVector32 x)
            => gbv.not(x);
        
        public static BitVector32 negate_bv_32u(BitVector32 x)
            => bitvector.negate(x);

        public static BitVector32 negate_bv_o32u(BitVector32 x)
            => -x;

        public static BitVector32 negate_bv_g32u(BitVector32 x)
            => gbv.negate(x);
        
        public static BitVector32 inc_bv_32u(BitVector32 x)
            => bitvector.inc(x);

        public static BitVector32 inc_bv_o32u(BitVector32 x)
            => ++x;

        public static BitVector32 inc_bv_g32u(BitVector32 x)
            => gbv.inc(x);

        public static BitVector32 dec_bv_32u(BitVector32 x)
            => bitvector.dec(x);

        public static BitVector32 dec_bv_o32u(BitVector32 x)
            => --x;

        public static BitVector32 dec_bv_g32u(BitVector32 x)
            => gbv.dec(x);    

        public static BitVector32 rotl_bv_32u(BitVector32 x, int offset)
            => x.Rotl(offset);

        public static BitVector32 rotl_bv_g32u(BitVector32 x, int offset)
            => gbv.rotl(x,offset);

        public static BitVector32 rotr_bv_32u(BitVector32 x, int offset)
            => x.Rotr(offset);

        public static BitVector32 rotr_bv_g32u(BitVector32 x, int offset)
            => gbv.rotr(x,offset);

    }

}