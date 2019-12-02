//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class bvoc
    {

        public static void bs_and(in Block256<uint> x, in Block256<uint> y, Block256<uint> z)
            => vblock.and(n256,x.BlockCount, 256/32, in x.Head, in y.Head, ref z.Head);

        public static BitVector128 and_128(BitVector128 x, BitVector128 y)
            => x & y;

        public static BitVector128 xnor_128(BitVector128 x, BitVector128 y)
            => BitVector.xnor(x,y);

        public static void partition(BitVector128 x, Span<BitVector32> dst)
            => BitVector.partition(x, dst);

        public static bit dot_64(BitVector64 x, BitVector64 y)
            => x % y;

        public static bit dot_128(BitVector128 x, BitVector128 y)
            => BitVector.dot(x,y);

        public static byte butterfly_8x1(byte x)
            => gbits.butterfly(n1,x);

        public static Vector128<byte> vbutterfly_128x8x1(Vector128<byte> x)
            => gbits.vbutterfly(n1,x);

        public static Vector256<byte> vbutterfly_256x8x1(Vector256<byte> x)
            => gbits.vbutterfly(n1,x);

        public static ushort butterfly_16x1(ushort x)
            => gbits.butterfly(n1,x);

        public static Vector128<ushort> vbutterfly_128x16x1(Vector128<ushort> x)
            => gbits.vbutterfly(n1,x);

        public static Vector256<ushort> vbutterfly_256x16x1(Vector256<ushort> x)
            => gbits.vbutterfly(n1,x);

        public static uint butterfly_32x1(uint x)
            => gbits.butterfly(n1,x);

        public static Vector128<uint> vbutterfly_128x32x1(Vector128<uint> x)
            => gbits.vbutterfly(n1,x);

        public static Vector256<uint> vbutterfly_256x32x1(Vector256<uint> x)
            => gbits.vbutterfly(n1,x);

        public static ulong butterfly_64x1(ulong x)
            => gbits.butterfly(n1,x);

        public static Vector128<ulong> vbutterfly_128x64x1(Vector128<ulong> x)
            => gbits.vbutterfly(n1,x);

        public static Vector256<ulong> vbutterfly_256x64x1(Vector256<ulong> x)
            => gbits.vbutterfly(n1,x);

        public static byte butterfly_8x2(byte x)
            => gbits.butterfly(n2,x);

        public static Vector128<byte> vbutterfly_128x8x2(Vector128<byte> x)
            => gbits.vbutterfly(n2,x);

        public static Vector256<byte> vbutterfly_256x8x2(Vector256<byte> x)
            => gbits.vbutterfly(n2,x);

        public static ushort butterfly_16x2(ushort x)
            => gbits.butterfly(n2,x);

        public static Vector128<ushort> vbutterfly_128x16x2(Vector128<ushort> x)
            => gbits.vbutterfly(n2,x);

        public static Vector256<ushort> vbutterfly_256x16x2(Vector256<ushort> x)
            => gbits.vbutterfly(n2,x);

        public static uint butterfly_32x2(uint x)
            => Bits.butterfly(n2,x);

        public static Vector128<uint> vbutterfly_128x32x2(Vector128<uint> x)
            => gbits.vbutterfly(n2,x);

        public static Vector256<uint> vbutterfly_256x32x2(Vector256<uint> x)
            => gbits.vbutterfly(n2,x);

        public static ulong butterfly_64x2(ulong x)
            => gbits.butterfly(n2,x);

        public static Vector128<ulong> vbutterfly_128x64x2(Vector128<ulong> x)
            => gbits.vbutterfly(n2,x);

        public static Vector256<ulong> vbutterfly_256x64x2(Vector256<ulong> x)
            => gbits.vbutterfly(n2,x);

        public static ushort butterfly_16x4(ushort x)
            => Bits.butterfly(n4,x);

        public static Vector128<ushort> vbutterfly_128x16x4(Vector128<ushort> x)
            => gbits.vbutterfly(n4,x);

        public static Vector256<ushort> vbutterfly_256x16x4(Vector256<ushort> x)
            => gbits.vbutterfly(n4,x);

        public static ulong butterfly_32x4(uint x)
            => Bits.butterfly(n4,x);

        public static Vector128<uint> vbutterfly_128x32x4(Vector128<uint> x)
            => gbits.vbutterfly(n4,x);

        public static Vector256<uint> vbutterfly_256x32x4(Vector256<uint> x)
            => gbits.vbutterfly(n4,x);

        public static ulong butterfly_64x4(ulong x)
            => Bits.butterfly(n4,x);

        public static Vector128<ulong> vbutterfly_128x64x4(Vector128<ulong> x)
            => gbits.vbutterfly(n4,x);

        public static Vector256<ulong> vbutterfly_256x64x4(Vector256<ulong> x)
            => gbits.vbutterfly(n4,x);

        public static ulong butterfly_32x8(uint x)
            => gbits.butterfly(n8,x);

        public static Vector128<uint> vbutterfly_128x32x8(Vector128<uint> x)
            => gbits.vbutterfly(n8,x);

        public static Vector256<uint> vbutterfly_256x32x8(Vector256<uint> x)
            => gbits.vbutterfly(n8,x);

        public static ulong butterfly_64x8(ulong x)
            => gbits.butterfly(n8,x);

        public static Vector128<ulong> vbutterfly_128x64x8(Vector128<ulong> x)
            => gbits.vbutterfly(n8,x);

        public static Vector256<ulong> vbutterfly_256x64x8(Vector256<ulong> x)
            => gbits.vbutterfly(n8,x);

        public static ulong butterfly_64x16(ulong x)
            => gbits.butterfly(n16,x);

        public static Vector128<ulong> vbutterfly_128x64x16(Vector128<ulong> x)
            => gbits.vbutterfly(n16,x);

        public static Vector256<ulong> vbutterfly_256x64x16(Vector256<ulong> x)
            => gbits.vbutterfly(n16,x);

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

        public static ReadOnlySpan<char> bitchars_8u(byte value)
            => BitStore.bitchars(value);


        public static void bitchars_8u(byte value, Span<char> dst)
            => BitStore.bitchars(value, dst);

        public static void bitchars_16u(ushort value, Span<char> dst)
            => BitStore.bitchars(value, dst);

        public static void bitchars_32u(uint value, Span<char> dst)
            => BitStore.bitchars(value, dst);

        public static void bitchars_64u(ulong value, Span<char> dst)
            => BitStore.bitchars(value, dst);

            
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

        public static uint blsmsk_d32u(uint src)
            => Bits.blsmsk(src);

        public static uint blsmsk_g32u(uint src)
            => gbits.blsmsk(src);

    }

}