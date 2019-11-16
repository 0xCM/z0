//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vsll : IntrinsicTest<t_vsll>
    {
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

        public void vsll_128x8u()
        {
            vsll_128_check<byte>();
        }

        public void vsll_128x8u_bench()
        {
            vsll_128_bench<byte>();
        }

        public void vsll_128x16u()
        {
            vsll_128_check<ushort>();
        }

        public void vsll_128x16u_bench()
        {
            vsll_128_bench<ushort>();
        }

        public void vsll_128x32u()
        {
            vsll_128_check<uint>();
        }

        public void vsll_128x32u_bench()
        {
            vsll_128_bench<uint>();
        }

        public void vsll_128x64u()
        {
            vsll_128_check<ulong>();
        }

        public void vsll_128x64u_bench()
        {
            vsll_128_bench<ulong>();
        }

        public void vsll_256x8u()
        {
            vsll_256_check<byte>();
        }

        public void vsll_256x8u_bench()
        {
            vsll_256_bench<byte>();
        }

        public void vsll_256x16u()
        {
            vsll_256_check<ushort>();
        }        

        public void vsll_256x16u_bench()
        {
            vsll_256_bench<ushort>();
        }        

        public void vsll_256x32u()
        {
            vsll_256_check<uint>();
        }        

        public void vsll_256x32u_bench()
        {
            vsll_256_bench<uint>();
        }        

        public void vsll_256x64u()
        {
            vsll_256_check<ulong>();
        }        

        public void vsll_256x64u_bench()
        {
            vsll_256_bench<ulong>();
        }        

        public void vsrl_128x8u()
        {
            vsrl_128_check<byte>();
        }

        public void vsrl_128x8u_bench()
        {
            vsrl_128_bench<byte>();
        }

        public void vsrl_128x16u()
        {
            vsrl_128_check<ushort>();
        }

        public void vsrl_128x16u_bench()
        {
            vsrl_128_bench<ushort>();
        }

        public void vsrl_128x32u()
        {
            vsrl_128_check<uint>();
        }

        public void vsrl_128x32u_bench()
        {
            vsrl_128_bench<uint>();
        }

        public void vsrl_128x64u()
        {
            vsrl_128_check<ulong>();
        }

        public void vsrl_128x64u_bench()
        {
            vsrl_128_bench<ulong>();
        }

        public void vsrl_256x8u()
        {
            vsrl_256_check<byte>();
        }

        public void vsrl_256x8u_bench()
        {
            vsrl_256_bench<byte>();
        }

        public void vsrl_256x16u()
        {
            vsrl_256_check<ushort>();
        }

        public void vsrl_256x16u_bench()
        {
            vsrl_256_bench<ushort>();
        }

        public void vsrl_256x32u()
        {
            vsrl_256_check<uint>();
        }

        public void vsrl_256x32u_bench()
        {
            vsrl_256_bench<uint>();
        }

        public void vsrl_256x64u()
        {
            vsrl_256_check<ulong>();
        }

        public void vsrl_256x64u_bench()
        {
            vsrl_256_bench<ulong>();
        }

        void vsll_128_check<T>()
            where T : unmanaged
        {

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVector<T>(n128);
                var offset = Random.Next<byte>(2,7);
                var dst = ginx.vsll(src,offset);
                for(var j=0; j<dst.Length(); j++)
                {
                    var x = ginx.vxscalar(dst, (byte)j);
                    var y = ginx.vxscalar(src, (byte)j);
                    Claim.eq(x, gmath.sll(y,offset));
                }
            }

        }

        void vsll_256_check<T>()
            where T : unmanaged
        {

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVector<T>(n256);
                var offset = Random.Next<byte>(2,7);
                var dst = ginx.vsll(src,offset);
                for(var j=0; j<dst.Length(); j++)
                {
                    var x = ginx.vxscalar(ginx.vlo(dst), (byte)j);
                    var y = ginx.vxscalar(ginx.vlo(src), (byte)j);
                    Claim.eq(x, gmath.sll(y,offset));

                    x = ginx.vxscalar(ginx.vhi(dst), (byte)j);
                    y = ginx.vxscalar(ginx.vhi(src), (byte)j);
                    Claim.eq(x, gmath.sll(y,offset));

                }
            }
        }

        void vsrl_128_check<T>()
            where T : unmanaged
        {

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVector<T>(n128);
                var offset = Random.Next<byte>(2,7);
                var dst = ginx.vsrl(src,offset);
                for(var j=0; j<dst.Length(); j++)
                {
                    var x = ginx.vxscalar(dst, (byte)j);
                    var y = ginx.vxscalar(src, (byte)j);
                    Claim.eq(x, gmath.srl(y,offset));
                }
            }
        }

        void vsrl_256_check<T>()
            where T : unmanaged
        {

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVector<T>(n256);
                var offset = Random.Next<byte>(2,7);
                var dst = ginx.vsrl(src,offset);
                for(var j=0; j<dst.Length(); j++)
                {
                    var x = ginx.vxscalar(ginx.vlo(dst), (byte)j);
                    var y = ginx.vxscalar(ginx.vlo(src), (byte)j);
                    Claim.eq(x, gmath.srl(y,offset));

                    x = ginx.vxscalar(ginx.vhi(dst), (byte)j);
                    y = ginx.vxscalar(ginx.vhi(src), (byte)j);
                    Claim.eq(x, gmath.srl(y,offset));

                }
            }

        }

        void vsll_128_bench<T>()
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = default(Vector128<T>);
            var sw = stopwatch(false);
            var bitlen = bitsize<T>();
            var opname = $"sll_128x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(n128);
                sw.Start();
                last = ginx.vsll(x,offset);
                sw.Stop();
            
            }
            Collect((opcount, sw, opname));

        }

        void vsll_256_bench<T>()
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = Vec256<T>.Zero;
            var sw = stopwatch(false);
            var bitlen = bitsize<T>();
            var opname = $"sll_256x{bitlen}u";

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

        void vsrl_128_bench<T>()
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = ginx.vzero<T>(n128);
            var sw = stopwatch(false);
            var bitlen = bitsize<T>();
            var opname = $"srl_128x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(n128);
                sw.Start();
                last = ginx.vsrl(x,offset);
                sw.Stop();
            
            }
            Collect((opcount, sw, opname));

        }

        void vsrl_256_bench<T>()
            where T : unmanaged
        {

            var opcount = RoundCount * CycleCount;
            var last = Vec256<T>.Zero;
            var sw = stopwatch(false);
            var bitlen = bitsize<T>();
            var opname = $"srl_256x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(n256);
                sw.Start();
                last = ginx.vsrl(x,offset);
                sw.Stop();
            
            }
            Collect((opcount, sw, opname));

        }


        void sll_8u_direct_bench()
        {
            var opname = $"sll_8u_direct";
            var sw = stopwatch(false);
            byte last = 0;
            var opcount = CycleCount*RoundCount;
            for(var i=0; i< opcount; i++)
            {
                var x = Random.Next<byte>();
                var offset = Random.Next<byte>((2,6));
                sw.Start();
                last = (byte)(x << offset);
                sw.Stop();
            }

            Collect((opcount, sw, opname));            
        }
        

        static Vector256<byte> ShuffleIdentityMask()
        {
            Span256<byte> mask = Span256.allocu<byte>(1);

            //For the first 128-bit lane
            var half = mask.Length/2;
            for(byte i=0; i< half; i++)
                mask[i] = i;

            //For the second 128-bit lane
            for(byte i=0; i< half; i++)
                mask[i + half] = i;

            return mask.LoadVector();
        }


        // Truncates alternating source vector components
        static Vector256<T> ShuffleTruncateMask<T>()
            where T : unmanaged

        {
            var mask = Span256.allocu<T>(1);
            var chop = PrimalInfo.Get<T>().MaxVal;
            
            //For the first 128-bit lane
            var half = mask.Length/2;
            for(byte i=0; i< half; i++)
            {
                if(i % 2 != 0)
                    mask[i] = chop;
                else
                    mask[i] = convert<byte,T>(i);
            }

            //For the second 128-bit lane
            for(byte i=0; i< half; i++)
            {
                if(i % 2 != 0)
                    mask[i + half] = chop;
                else
                    mask[i + half] = convert<byte,T>(i);
            }

            return mask.LoadVector();
        }

        static Vector256<T> BlendAltMask<T>()
            where T : unmanaged
        {
            Span256<T> mask = Span256.allocu<T>(1);
            var no = PrimalInfo.Get<T>().MaxVal;
            var yes = PrimalInfo.Get<T>().Zero;
            for(byte i=0; i< mask.Length; i++)
            {
                                
                if(i % 2 == 0)
                    mask[i] = yes;
                else
                    mask[i] = no;
            }
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
    }
}