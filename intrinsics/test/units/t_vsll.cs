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

    public class t_vsll : IntrinsicTest<t_vsll>
    {
        public void vsll_128x8u()
            => vsll_check<byte>(n128);

        public void vsll_128x16u()
            => vsll_check<ushort>(n128);

        public void vsll_128x32u()
            => vsll_check<uint>(n128);

        public void vsll_128x64u()
            => vsll_check<ulong>(n128);

        public void vsll_256x8u()
            => vsll_check<byte>(n256);

        public void vsll_256x16u()
            => vsll_check<ushort>(n256);

        public void vsll_256x32u()
            => vsll_check<uint>(n256);


        public void vsll_256x64u()
            => vsll_check<ulong>(n256);

        public void vsll_128x8u_bench()
            =>vsll_bench<byte>(n128);

        public void vsll_128x16u_bench()
            => vsll_bench<ushort>(n128);

        public void vsll_128x32u_bench()
            => vsll_bench<uint>(n128);

        public void vsll_128x64u_bench()
            => vsll_bench<ulong>(n128);

        public void vsll_256x8u_bench()
            => vsll_bench<byte>(n256);

        public void vsll_256x16u_bench()
            => vsll_bench<ushort>(n256);

        public void vsll_256x32u_bench()
            => vsll_bench<uint>(n256);

        public void vsll_256x64u_bench()
            => vsll_bench<ulong>(n256);

        void vsll_check<T>(N128 n)
            where T : unmanaged
        {

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVector<T>(n);
                var offset = Random.Next<byte>(2,7);
                var dst = ginx.vsll(src,offset);
                for(var j=0; j<dst.Length(); j++)
                {
                    var x = vcell(dst, (byte)j);
                    var y = vcell(src, (byte)j);
                    Claim.eq(x, gmath.sll(y,offset));
                }
            }

        }

        void vsll_check<T>(N256 n)
            where T : unmanaged
        {

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVector<T>(n);
                var offset = Random.Next<byte>(2,7);
                var vOffset = ginx.vscalar(n128,convert<byte,T>(offset));

                var a = ginx.vsll(src, offset);
                var b = ginx.vsll(src, vOffset);
                Claim.eq(a,b);

                for(var j=0; j<a.Length()/2; j++)
                {
                    var x = vcell(ginx.vlo(a), (byte)j);
                    var y = vcell(ginx.vlo(src), (byte)j);
                    Claim.eq(x, gmath.sll(y,offset));

                    x = vcell(ginx.vhi(a), (byte)j);
                    y = vcell(ginx.vhi(src), (byte)j);
                    Claim.eq(x, gmath.sll(y,offset));
                }
            }
        }

        void vsll_bench<T>(N128 n)
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = vzero<T>(n);
            var sw = stopwatch(false);
            var bitlen = bitsize<T>();
            var opname = $"sll_{n}x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(n);
                sw.Start();
                last = ginx.vsll(x,offset);
                sw.Stop();
            
            }
            Collect((opcount, sw, opname));
        }

        void vsll_bench<T>(N256 n)
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = vzero<T>(n);
            var sw = stopwatch(false);
            var bitlen = bitsize<T>();
            var opname = $"sll_{n}x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(n256);
                sw.Start();
                last = ginx.vsll(x,offset);
                sw.Stop();
            
            }
            Collect((opcount, sw, opname));
        }


        static Vector256<byte> ShuffleIdentityMask()
        {
            Block256<byte> mask = DataBlocks.cellalloc<byte>(n256,1);

            //For the first 128-bit lane
            var half = mask.CellCount/2;
            for(byte i=0; i< half; i++)
                mask[i] = i;

            //For the second 128-bit lane
            for(byte i=0; i< half; i++)
                mask[i + half] = i;

            return mask.LoadVector();
        }

        static BitVector32[]  GfPoly =
        {
            0b00000000000000000000000000000000,
            0b00000000000000000000000000000001,
            0b00000000000000000000000000000111,
            0b00000000000000000000000000001101,
            0b00000000000000000000000000010111,
            0b00000000000000000000000000101101,
            0b00000000000000000000000001100111,
            0b00000000000000000000000011010011,
            0b00000000000000000000000110110011,
            0b00000000000000000000001111111101,
            0b00000000000000000000011111011011,
            0b00000000000000000000111110100101,
            0b00000000000000000010011110001011,
            0b00000000000000000100111001000001,
            0b00000000000000001010010001110111,
            0b00000000000000011000011010100011,
            0b00000000000000110011010001011101,
            0b00000000000001100001101010001011,
            0b00000000000011110100001100001001,
            0b00000000000111101000010010101111,
            0b00000000001111010000100100001011,
            0b00000000100110001001011010000101,
            0b00000001001100010010110100000011,
            0b00000010011000100101101000101001,
            0b00000101111101011110000111001111,
            0b00001011111010111100001000001011,
            0b00010111110101111000010001101011,
            0b00111011100110101100101000101111,
            0b01110111001101011001010000001011,
            0b11101110011010110010100000000101,
        };

        BitVector32 gfmul(BitVector32 x, BitVector32 y, int w)
        {

            var result = 0u;
            BitVector32 ws1 = (1u << w) - 1u;
            BitVector32 ws2 = 1u << (w - 1);
            
            Span<BitVector32> dot = stackalloc BitVector32[w];
            for (var i = 0; i < w; i++) 
            {
                dot[i] = y;
                if ((y & ws2 ) != BitVector32.Zero)
                {
                    y <<= 1;
                    y = (y ^ GfPoly[w]) & ws1;
                } 
                else 
                    y <<= 1;
            }

            for (var i = 0; i < w; i++) 
            {
                var index = (1u << i);
                if ((index & x) != 0) 
                {
                    var j = 1u;
                    for (var k = 0; k < w; k++) 
                    {
                        result = result ^ (j & dot[i]);
                        j <<= 1;
                    }
                }
            }
            return result;
        }

        // static __m128i reflect_xmm(__m128i X)
        // {
        //     __m128i tmp1,tmp2;
        //     __m128i AND_MASK = _mm_set_epi32(0x0f0f0f0f, 0x0f0f0f0f, 0x0f0f0f0f, 0x0f0f0f0f);
        //     __m128i LOWER_MASK = _mm_set_epi32(0x0f070b03, 0x0d050901, 0x0e060a02, 0x0c040800);
        //     __m128i HIGHER_MASK = _mm_set_epi32(0xf070b030, 0xd0509010, 0xe060a020, 0xc0408000);
        //     __m128i BSWAP_MASK = _mm_set_epi8(0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15);
        //     tmp2 = _mm_srli_epi16(X, 4);
        //     tmp1 = _mm_and_si128(X, AND_MASK);
        //     tmp2 = _mm_and_si128(tmp2, AND_MASK);
        //     tmp1 = _mm_shuffle_epi8(HIGHER_MASK ,tmp1);
        //     tmp2 = _mm_shuffle_epi8(LOWER_MASK ,tmp2);
        //     tmp1 = _mm_xor_si128(tmp1, tmp2);
        //     return _mm_shuffle_epi8(tmp1, BSWAP_MASK);
        // }


        // public void TestReflect()
        // {
        //     var bs = BitString.FromPattern((ushort)0b1001_0101_1010_0110, 8);
        //     var v1 = bs.ToCpuVec<byte>(n128);
        //     var v2 = (Vec128<byte>)reflect_xmm(v1);                    
        // }


        //Intel code sample from Carryless multiplication document
        public static Vector128<ulong> gfmul(Vector128<ulong> a, Vector128<ulong> b)
        {

            var tmp3 = dinx.clmul(a, b, ClMulMask.X00);            
            var tmp4 = dinx.clmul(a, b, ClMulMask.X10);            
            var tmp5 = dinx.clmul(a, b, ClMulMask.X01);
            var tmp6 = dinx.clmul(a, b, ClMulMask.X11);
            
            tmp4 = dinx.vxor(tmp4, tmp5);            
            tmp5 = dinx.vsll(tmp4, 8);
            tmp4 = dinx.vsrl(tmp4, 8);            
            tmp3 = dinx.vxor(tmp3, tmp5);            
            tmp6 = dinx.vxor(tmp6, tmp4);
            
            var tmp7 = dinx.vsrl(tmp3, 31);
            var tmp8 = dinx.vsrl(tmp6, 31);            
            tmp3 = dinx.vsll(tmp3, 1);
            tmp6 = dinx.vsll(tmp6, 1);

            var tmp9 = dinx.vsrl(tmp7, 12);            
            tmp8 = dinx.vsll(tmp8, 4);
            tmp7 = dinx.vsll(tmp7, 4);
            tmp3 = dinx.vor(tmp3, tmp7);
            tmp6 = dinx.vor(tmp6, tmp8);
            tmp6 = dinx.vor(tmp6, tmp9);

            tmp7 = dinx.vsll(tmp3, 31);
            tmp8 = dinx.vsll(tmp3, 30);
            tmp9 = dinx.vsll(tmp3, 25);

            tmp7 = dinx.vxor(tmp7, tmp8);
            tmp7 = dinx.vxor(tmp7, tmp9);            
            tmp8 = dinx.vsrl(tmp7, 4);
            tmp7 = dinx.vsll(tmp7, 12);            
            tmp3 = dinx.vxor(tmp3, tmp7);

            var tmp2 = dinx.vsrl(tmp3, 1);
            tmp4 = dinx.vsrl(tmp3, 2);
            tmp5 = dinx.vsll(tmp3, 7);
            tmp2 = dinx.vxor(tmp2, tmp4);
            tmp2 = dinx.vxor(tmp2, tmp5);
            tmp2 = dinx.vxor(tmp2, tmp8);
            tmp3 = dinx.vxor(tmp3, tmp2);
            tmp6 = dinx.vxor(tmp6, tmp3);

            return tmp6;            
        }

        public void shuffleId()
        {
            var id = ShuffleIdentityMask();
            for(var i=0; i<DefaltCycleCount; i++)
            {
                var x = Random.CpuVector<byte>(n256);
                var y = dinx.vshuf16x8(x, id);
                Claim.eq(x,y);
            }
        }
    }
}