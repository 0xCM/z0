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

        public static ReadOnlySpan<char> bitchars_32u(uint value)
            => gbits.bitchars(value);

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
 
         //https://stackoverflow.com/questions/17803889/set-or-reset-a-given-bit-without-branching
        public static ref ulong bitset_2(ref ulong src, int pos, bit state)
        {
            src = (src & ~(1ul << pos)) | ((ulong)state << pos);
            return ref src;            
        }
        
        
        public static ref ulong bitset_3(ref ulong src, byte pos, bit state)
            => ref BitMask.set(ref src, pos, state);
         

        [MethodImpl(Inline)]        
        public static ref ulong bitmask_set(ref ulong src, byte pos, bit state)            
        {
            if(state) BitMask.enable(ref src, pos);
            else BitMask.disable(ref src, pos);
            return ref src;
        }

        public static byte blsmsk_d8u(byte src)
            => Bits.blsmsk(src);

        public static byte blsmsk_g8u(byte src)
            => gbits.blsmsk(src);

        public static ushort blsmsk_d16u(ushort src)
            => Bits.blsmsk(src);

        public static ushort blsmsk_g16u(ushort src)
            => gbits.blsmsk(src);

        public static uint blsmsk_d32u(uint src)
            => Bits.blsmsk(src);

        public static uint blsmsk_g32u(uint src)
            => gbits.blsmsk(src);

        public static ulong blsmsk_g64u(ulong src)
            => gbits.blsmsk(src);

        public static ulong blsmsk_d64u(ulong src)
            => Bits.blsmsk(src);
    }

}