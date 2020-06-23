//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Memories;
        
    public class t_bitmix : t_bitcore<t_bitmix>
    {
        public void bitmix_8()
            => bitmix_check<byte>();

        public void bitmix_16()
            => bitmix_check<ushort>();

        public void bitmix_32()
            => bitmix_check<uint>();

        public void bitmix_64()
            => bitmix_check<ulong>();

        /// <summary>
        /// Verifies even/odd bit-level interspersal
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        void bitmix_check<T>(T t = default)
            where T : unmanaged
        {
            var len = bitsize<T>();

            for(var i=0; i<RepCount; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next<T>();

                // odd a/b interspersal
                var abOdd = BitString.scalar(gbits.mix(n1,a,b));

                // even a/b interspersal
                var abEven = BitString.scalar(gbits.mix(n0,a,b));

                // even/odd bits for a/b via bitstring
                var bsaEven = BitString.scalar(a).Even();
                var bsaOdd = BitString.scalar(a).Odd();
                var bsbEven = BitString.scalar(b).Even();
                var bsbOdd = BitString.scalar(b).Odd();
                
                // bitstring reference interspersal for the even bits
                var bsEven = bsaEven.Intersperse(bsbEven);                
                Claim.yea(bsEven == abEven);

                // bitstring reference interspersal for the odd bits
                var bsOdd = bsaOdd.Intersperse(bsbOdd);
                Claim.yea(bsOdd == abOdd);                                
            }
        }

        public void bitmix_outline()
        {
            for(var i=0; i<RepCount; i++)
            {
                BitVector64 x = Random.BitVector(n64);
                BitVector32 y = (uint)Bits.gather(x, BitMasks.Even64);
                BitVector32 z = default;

                for(int j=0, k = 0; j<64; j+=2, k++)
                    z[k] = x[j];

                Claim.Eq(z.Scalar, y.Scalar);
            }            

            for(var i=0; i<RepCount; i++)
            {
                BitVector64 x = Random.BitVector(n64);
                BitVector32 y = (uint)Bits.gather(x, BitMasks.Odd64);
                BitVector32 z = default;

                for(int j=1, k = 0; j<64; j+=2, k++)
                    z[k] = x[j];

                Claim.Eq(z.Scalar, y.Scalar);
            }
        }

        string sb_mix_report()
        {            
            var x = Random.Next<uint>();
            var y = Random.Next<uint>();
            var xE = Bits.scatter(Bits.gather(x,BitMasks.Even32), BitMasks.Even32);
            var xO = Bits.scatter(Bits.gather(x,BitMasks.Odd32), BitMasks.Even32);
            var yE = Bits.scatter(Bits.gather(y,BitMasks.Even32), BitMasks.Odd32);
            var yO = Bits.scatter(Bits.gather(y,BitMasks.Odd32), BitMasks.Odd32);
            var xEy = xE | yE;
            var xOy = xO | yO;
            var t = text.build();
            var sep = Chars.Colon;
            t.Label("x", sep, x.FormatBits(1));
            t.Label("x", sep, x.FormatBits(1));
            t.Label("y", sep, y.FormatBits(1));
            t.Label("xE", sep, xE.FormatBits(1));
            t.Label("xO", sep, xO.FormatBits(1));
            t.Label("yE", sep, yE.FormatBits(1));
            t.Label("yO", sep, yO.FormatBits(1));
            t.Label("xEy", sep, xEy.FormatBits(1));
            t.Label("xOy", sep, xOy.FormatBits(1));
            return t.ToString();
        }
    }
}