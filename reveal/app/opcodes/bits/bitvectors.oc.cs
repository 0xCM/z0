//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    [OpCodeProvider]
    public static class bitvectors
    {
        public static BitVector<byte> bvand_8(BitVector<byte> x, BitVector<byte> y)
            => BV.bvand(z8).Invoke(x,y);

        public static BitVector8 bvand_d8(BitVector8 x, BitVector8 y)
            => BitVector.and(x,y);

        public static BitVector<uint> bvand_32(BitVector<uint> x, BitVector<uint> y)
            => BV.bvand(z32).Invoke(x,y);

        public static BitVector32 bvand_d32(BitVector32 x, BitVector32 y)
            => BitVector.and(x,y);

        public static BitVector<ulong> bvand_64(BitVector<ulong> x, BitVector<ulong> y)
            => BV.bvand(z64).Invoke(x,y);

        public static BitVector64 bvand_d64(BitVector64 x, BitVector64 y)
            => BitVector.and(x,y);

        public static BitVector<byte> bvxor_8(BitVector<byte> x, BitVector<byte> y)
            => BV.bvxor(z8).Invoke(x,y);

        public static BitVector<byte> bvxor_g8(BitVector<byte> x, BitVector<byte> y)
            => BitVector.xor(x,y);

        public static BitVector8 bvxor_d8(BitVector8 x, BitVector8 y)
            => BitVector.xor(x,y);
        
        public static byte xor_d8(byte x, byte y)
            => (byte)(x ^ y);

        public static byte xor_g8(byte x, byte y)
            => gmath.xor(x,y);

        public static byte xor_d82(byte x, byte y)
            => math.xor(x,y);

        public static BitVector32 sll_bv_32u(BitVector32 x, byte offset)
            => BitVector.sll(x,offset);

        public static BitVector32 sll_bv_o32u(BitVector32 x, byte offset)
            => x << offset;
        
        public static BitVector32 srl_bv_32u(BitVector32 x, byte offset)
            => BitVector.srl(x,offset);

        public static BitVector32 srl_bv_o32u(BitVector32 x, byte offset)
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

        public static BitVector32 rotl_bv_32u(BitVector32 x, byte offset)
            => BitVector.rotl(x,offset);

        public static BitVector32 rotr_bv_32u(BitVector32 x, byte offset)
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
            return BitMatrix.oprod(x,y);
        }

        public static BitMatrix<uint> oprod_2(BitVector<uint> x, BitVector<uint> y)
        {
            return BitMatrix.oprod(x,y);
        }

        public static ref BitMatrix<uint> oprod_3(BitVector<uint> x, BitVector<uint> y, ref BitMatrix<uint> z)
        {
            return ref BitMatrix.oprod(x,y, ref z);
        }

        public static ref BitMatrix<ulong> oprod_4(BitVector<ulong> x, BitVector<ulong> y, ref BitMatrix<ulong> z)
        {
            return ref BitMatrix.oprod(x,y, ref z);
        }


    }

}