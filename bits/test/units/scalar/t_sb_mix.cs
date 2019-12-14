//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
        
    public class t_sb_mix : t_sb<t_sb_mix>
    {
        public void sb_mix_8()
            => sb_mix_check<byte>();

        public void sb_mix_16()
            => sb_mix_check<ushort>();

        public void sb_mix_32()
            => sb_mix_check<uint>();

        public void sb_mix_64()
            => sb_mix_check<ulong>();

        public void sb_mix_outline()
        {
            for(var i=0; i<SampleSize; i++)
            {
                BitVector64 x = Random.BitVector(n64);
                BitVector32 y = (uint)Bits.select(x, BitMasks.Even64);
                BitVector32 z = default;

                for(int j=0, k = 0; j<64; j+=2, k++)
                    z[k] = x[j];

                Claim.eq(z, y);
            }            

            for(var i=0; i<SampleSize; i++)
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
            var t = text();
            t.WithLabeled("x", x.FormatBits(blockWidth:1));
            t.WithLabeled("x", x.FormatBits(blockWidth:1));
            t.WithLabeled("y", y.FormatBits(blockWidth:1));
            t.WithLabeled("xE", xE.FormatBits(blockWidth:1));
            t.WithLabeled("xO", xO.FormatBits(blockWidth:1));
            t.WithLabeled("yE", yE.FormatBits(blockWidth:1));
            t.WithLabeled("yO", yO.FormatBits(blockWidth:1));
            t.WithLabeled("xEy", xEy.FormatBits(blockWidth:1));
            t.WithLabeled("xOy", xOy.FormatBits(blockWidth:1));
            return t.ToString();
        }

        void mix32_even_outline()
        {            
            var n = n32;
            var parity = n0;
            for(var sample = 0; sample < SampleSize; sample ++)
            {
                var x = Random.BitVector(n);
                var y = Random.BitVector(n);
                BitVector32 xEy = Bits.mix(parity, x, y);

                var z = BitVector.alloc(n32);
                for(var i=0; i<n; i+=2)
                {
                    z[i]  =  x[i];
                    z[i+1] = y[i];
                }

                void trace()
                {
                    var p = BitVector.broadcast(n,0b10101010);
                    Trace("x", x.Format(1));
                    Trace("y", y.Format(1));
                    Trace("p", p.Format(1));
                    Trace("xEy", xEy.Format(1));
                }
                
                if(z != xEy)
                    trace();

                Claim.eq(z,xEy);        
            }
        }
    }
}