//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static zfunc;
    using static nfunc;
 
    public sealed class t_uint8 : UnitTest<t_uint8>
    {
        protected override int CycleCount => Pow2.T24;

        public void bv8_ops_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var a = Random.Next<byte>();
                var b = Random.Next<byte>();

                UInt8 va = a;
                UInt8 vb = b;

                Claim.eq(math.add(a,b), va + vb);
                Claim.eq(math.sub(a,b), va - vb);
                Claim.eq(math.mul(a,b), va * vb);
                if(b != 0)
                {
                    Claim.eq(math.div(a,b), va / vb);
                    Claim.eq(math.mod(a,b), va % vb);
                }
                Claim.eq(math.negate(a), -va);
                Claim.eq(math.and(a,b), va & vb);
                Claim.eq(math.or(a,b), va | vb);
                Claim.eq(math.xor(a, b), va ^ vb);
                Claim.eq(math.not(a), ~va);
                Claim.eq(math.sll(a,3), va << 3);
                Claim.eq(math.srl(a,3), va >> 3);
            }

            var c = byte.MinValue;
            var d = UInt8.Zero;
            
            for(var i=0; i<300; i++)
            {
                c++;
                d++;
                Claim.eq(c,d);
            }

            for(var i=0; i<300; i++)
            {
                c--;
                d--;
                Claim.eq(c,d);
            }

        }

       public void bench_ops()
        {
            if(odd(DateTime.Now.Ticks))
            {
                RunBench<byte>(PrimalBench.bench_byte);
                RunBench<UInt8>(PrimalBench.bench_uint8,Random.Next<byte>(),Random.Next<byte>());
            }
            else
            {
                RunBench<UInt8>(PrimalBench.bench_uint8,Random.Next<byte>(),Random.Next<byte>());
                RunBench<byte>(PrimalBench.bench_byte);
            }
        }




    }

}