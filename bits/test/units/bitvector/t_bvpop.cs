//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static dinx;

    public class t_bvpop : BitVectorTest<t_bvpop>
    {
        const ulong k1 = 0x5555555555555555;
        
        const ulong k2 = 0x3333333333333333;
        
        const ulong k4 = 0x0f0f0f0f0f0f0f0f;
        
        const ulong kf = 0x0101010101010101; 

        static Vector256<ulong> K1 => dinx.vbroadcast(n256, k1);
        static Vector256<ulong> K2 => dinx.vbroadcast(n256, k2);

        static Vector256<ulong> K4 => dinx.vbroadcast(n256, k4);

        static Vector256<ulong> Kf => dinx.vbroadcast(n256, kf);

        // https://www.chessprogramming.org/Population_Count
        uint pop (ulong x, ulong y, ulong z) 
        {
            var maj = ((x ^ y ) & z) | (x & y);
            var odd = ((x ^ y ) ^ z);
            
            maj =  maj - ((maj >> 1) & k1 );
            odd =  odd - ((odd >> 1) & k1 );
            
            maj = (maj & k2) + ((maj >> 2) & k2);
            odd = (odd & k2) + ((odd >> 2) & k2);
            
            maj = (maj + (maj >> 4)) & k4;
            odd = (odd + (odd >> 4)) & k4;
            
            odd = ((maj + maj + odd) * kf ) >> 56;
            return (uint) odd;
        }        
        
        uint pop(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z)
        {
            var maj =  vor(vand(vxor(x,y),z), vand(x,y));
            var odd =  vxor(vxor(x,y),z);
            
            maj = vsub(maj, vand(vsrl(maj, 1), K1));
            odd = vsub(odd, vand(vsrl(odd, 1), K1));
            
            maj = vadd(vand(maj,K2), vand(vsrl(maj, 2), K2));
            odd = vadd(vand(odd,K2), vand(vsrl(odd, 2), K2));

            maj = vand(vadd(maj, vsrl(maj,4)), K4);
            odd = vand(vadd(odd, vsrl(odd,4)), K4);
            
            var dst = vadd(vadd(maj, maj), odd).ToSpan();
            var total = 0ul;
            for(var i = 0; i< 4; i++ )
                total += dst[i]*kf >> 56;
            return (uint)total;            
        }

        public void pop_3()
        {
            var src = Random.BlockedSpan<ulong>(n256, 3, (0,uint.MaxValue));
            var x0 = src.TakeVector(0);
            var x1 = src.TakeVector(1);
            var x2 = src.TakeVector(2);
            var pop2 = 0u;
            var pop3 = 0u;
            for(var i=0; i< src.Length; i++)
            {
                pop2 += Bits.pop(src[i]);
                pop3 += pop(src[i],0,0);
            }

            Claim.eq(pop2,pop3);

        }


        public void pop_generic()
        {
            BitSize bitlen = 128 + 8;
            ByteSize bytelen = (ByteSize)bitlen;
            Claim.eq((int)bytelen, (int)bitlen/8);
            for(var i=0; i<CycleCount; i++)
            {
                var bv = Random.BitCells<ulong>(bitlen);
                var actual = bv.Pop();
                var expect = 0ul;
                var bytes = bv.Bytes;
                for(var j=0; j< bytes.Length; j++)
                    expect += Bits.pop(bytes[j]);
                Claim.eq(expect, actual);
                
            }

        }

        public void pop_spans()
        {
            var src = Random.Span<ulong>(SampleSize);
            var actual = bitspan.pop(src);
            
            var expect = 0u;
            for(var i=0; i<src.Length; i++)
            {
                expect += gbits.pop(src[i]);
            }
            Claim.eq(expect, actual);
        }


    }

}