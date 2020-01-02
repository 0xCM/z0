//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class bitvectors
    {
        public static BitVector32 and_bv_32u(BitVector32 x, BitVector32 y)
            => BitVector.and(x,y);

        public static BitVector32 and_bv_o32u(BitVector32 x, BitVector32 y)
            => x & y;

        public static BitVector32 or_bv_32u(BitVector32 x, BitVector32 y)
            => BitVector.or(x,y);

        public static BitVector32 or_bv_o32u(BitVector32 x, BitVector32 y)
            => x | y;
        
        public static BitVector32 xor_bv_32u(BitVector32 x, BitVector32 y)
            => BitVector.xor(x,y);

        public static BitVector32 xor_bv_o32u(BitVector32 x, BitVector32 y)
            => x ^ y;

        public static BitVector32 sll_bv_32u(BitVector32 x, int offset)
            => BitVector.sll(x,offset);

        public static BitVector32 sll_bv_o32u(BitVector32 x, int offset)
            => x << offset;
        
        public static BitVector32 srl_bv_32u(BitVector32 x, int offset)
            => BitVector.srl(x,offset);

        public static BitVector32 srl_bv_o32u(BitVector32 x, int offset)
            => x >> offset;

        public static BitVector32 flip_bv_32u(BitVector32 x)
            => BitVector.not(x);

        public static BitVector32 flip_bv_o32u(BitVector32 x)
            => ~x;
        
        public static BitVector32 negate_bv_32u(BitVector32 x)
            => BitVector.negate(x);

        public static BitVector32 negate_bv_o32u(BitVector32 x)
            => -x;

        public static BitVector32 inc_bv_32u(BitVector32 x)
            => BitVector.inc(x);

        public static BitVector32 inc_bv_o32u(BitVector32 x)
            => ++x;

        public static BitVector32 dec_bv_32u(BitVector32 x)
            => BitVector.dec(x);

        public static BitVector32 dec_bv_o32u(BitVector32 x)
            => --x;

        public static BitVector32 rotl_bv_32u(BitVector32 x, int offset)
            => BitVector.rotl(x,offset);

        public static BitVector32 rotr_bv_32u(BitVector32 x, int offset)
            => BitVector.rotr(x, offset);

        public static BitVector32 alt_32()
            => BitVector.alt(n32, off);

        public static BitVector<uint> alt_32g()
            => BitVector.alt<uint>(off);

        public static bit dot_32g(BitVector<uint> x, BitVector<uint> y)
        {
            return BitVector.dot(x,y);
        }

        public static BitMatrix<uint> oprod_1(BitVector32 x, BitVector32 y)
        {
            return BitVector.oprod(x,y);
        }

        public static BitMatrix<uint> oprod_2(BitVector<uint> x, BitVector<uint> y)
        {
            return BitVector.oprod(x,y);
        }

        public static ref BitMatrix<uint> oprod_3(BitVector<uint> x, BitVector<uint> y, ref BitMatrix<uint> z)
        {
            return ref BitVector.oprod(x,y, ref z);
        }

        public static ref BitMatrix<ulong> oprod_4(BitVector<ulong> x, BitVector<ulong> y, ref BitMatrix<ulong> z)
        {
            return ref BitVector.oprod(x,y, ref z);
        }


    }

}