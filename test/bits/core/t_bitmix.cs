//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
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
                Claim.eq(bsEven, abEven);

                // bitstring reference interspersal for the odd bits
                var bsOdd = bsaOdd.Intersperse(bsbOdd);
                Claim.eq(bsOdd, abOdd);                                
            }
        }

        public void bitmix_outline()
        {
            for(var i=0; i<RepCount; i++)
            {
                BitVector64 x = Random.BitVector(n64);
                BitVector32 y = (uint)Bits.select(x, BitMasks.Even64);
                BitVector32 z = default;

                for(int j=0, k = 0; j<64; j+=2, k++)
                    z[k] = x[j];

                Claim.eq(z, y);
            }            

            for(var i=0; i<RepCount; i++)
            {
                BitVector64 x = Random.BitVector(n64);
                BitVector32 y = (uint)Bits.select(x, BitMasks.Odd64);
                BitVector32 z = default;

                for(int j=1, k = 0; j<64; j+=2, k++)
                    z[k] = x[j];

                Claim.eq(z, y);
            }
        }

        string sb_mix_report()
        {            
            var x = Random.Next<uint>();
            var y = Random.Next<uint>();
            var xE = Bits.project(Bits.select(x,BitMasks.Even32), BitMasks.Even32);
            var xO = Bits.project(Bits.select(x,BitMasks.Odd32), BitMasks.Even32);
            var yE = Bits.project(Bits.select(y,BitMasks.Even32), BitMasks.Odd32);
            var yO = Bits.project(Bits.select(y,BitMasks.Odd32), BitMasks.Odd32);
            var xEy = xE | yE;
            var xOy = xO | yO;
            var t = text.factory.Builder();
            var sep = Chars.Colon;
            t.AppendLabeled("x", sep, x.FormatBits(blockwidth:1));
            t.AppendLabeled("x", sep, x.FormatBits(blockwidth:1));
            t.AppendLabeled("y", sep, y.FormatBits(blockwidth:1));
            t.AppendLabeled("xE", sep, xE.FormatBits(blockwidth:1));
            t.AppendLabeled("xO", sep, xO.FormatBits(blockwidth:1));
            t.AppendLabeled("yE", sep, yE.FormatBits(blockwidth:1));
            t.AppendLabeled("yO", sep, yO.FormatBits(blockwidth:1));
            t.AppendLabeled("xEy", sep, xEy.FormatBits(blockwidth:1));
            t.AppendLabeled("xOy", sep, xOy.FormatBits(blockwidth:1));
            return t.ToString();
        }
    }
}