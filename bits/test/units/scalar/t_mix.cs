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

    using static zfunc;
    using static BitParts;
        
    public class t_mix : ScalarBitTest<t_mix>
    {
        public void mix8()
            => mix_check<byte>();

        public void mix16()
            => mix_check<ushort>();

        public void mix32()
            => mix_check<uint>();

        public void mix64()
            => mix_check<ulong>();

        void mix_check<T>()
            where T : unmanaged
        {
            var len = bitsize<T>();

            for(var i=0; i<SampleSize; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next<T>();

                var aOb = BitString.from(gbits.mix(n1,a,b));
                var aEb = BitString.from(gbits.mix(n0,a,b));

                var bs1E = BitString.from(a).Even();
                var bs2E = BitString.from(b).Even();
                var bs3E = bs1E.Intersperse(bs2E);
                
                Claim.eq(bs3E, aEb);

                var bs1O = BitString.from(a).Odd();
                var bs2O = BitString.from(b).Odd();
                var bs3O = bs1O.Intersperse(bs2O);

                Claim.eq(bs3O, aOb);

                
                
            }
        }

        void mix_example()
        {
            var x = Random.Next<uint>();
            var y = Random.Next<uint>();
            var xE = BitParts.project(BitParts.select(x,Even32.Select), Even32.Select);
            var xO = BitParts.project(BitParts.select(x,Odd32.Select), Even32.Select);
            var yE = BitParts.project(BitParts.select(y,Even32.Select), Odd32.Select);
            var yO = BitParts.project(BitParts.select(y,Odd32.Select), Odd32.Select);
            var xEy = xE | yE;
            var xOy = xO | yO;
            Trace("x", x.FormatBits(blockWidth:1));
            Trace("y", y.FormatBits(blockWidth:1));
            Trace("xE", xE.FormatBits(blockWidth:1));
            Trace("xO", xO.FormatBits(blockWidth:1));
            Trace("yE", yE.FormatBits(blockWidth:1));
            Trace("yO", yO.FormatBits(blockWidth:1));
            Trace("xEy", xEy.FormatBits(blockWidth:1));
            Trace("xOy", xOy.FormatBits(blockWidth:1));
        }

        void mix32_even_example()
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
                    Trace("x", x.Format(blockWidth:1));
                    Trace("y", y.Format(blockWidth:1));
                    Trace("p", p.Format(blockWidth:1));
                    Trace("xEy", xEy.Format(blockWidth:1));
                }
                
                if(z != xEy)
                    trace();

                Claim.eq(z,xEy);        
            }
        }

        void mix64_even_example()
        {
            for(var i=0; i<SampleSize; i++)
            {
                BitVector64 x = Random.BitVector(n64);
                BitVector32 y = (uint)BitParts.select(x, Even64.Select);
                BitVector32 z = default;

                for(int j=0, k = 0; j<64; j+=2, k++)
                    z[k] = x[j];

                Claim.eq(z, y);

            }
            
        }

        void mix64_odd_example()
        {
            for(var i=0; i<SampleSize; i++)
            {
                BitVector64 x = Random.BitVector(n64);
                BitVector32 y = (uint)BitParts.select(x, Odd64.Select);
                BitVector32 z = default;

                for(int j=1, k = 0; j<64; j+=2, k++)
                    z[k] = x[j];

                Claim.eq(z, y);
            }
        }
    }

}