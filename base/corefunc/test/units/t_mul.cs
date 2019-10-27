//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using System.Runtime.CompilerServices;
    using static zfunc;

    public sealed class t_mul : UnitTest<t_mul>
    {
        protected override int SampleSize => Pow2.T12;
        
        public void mul_32()
        {
            const uint MAX = uint.MaxValue;
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<uint>(2, Pow2.T08);
                var y = Random.Next<uint>(2, Pow2.T08);
                var z = Random.Next<uint>(2, Pow2.T08);
            
                var lo = BmiMul.lo(x,y);
                Claim.eq(x*y,lo);

                var hi = BmiMul.hi(x,y);
                Claim.eq(0,hi);

                var h2 = BmiMul.hi(z,MAX);
                Claim.nonzero(h2);
                var h3 = MulOps.hi(z,MAX);
                Claim.eq(h3,h2);

                var l2 = BmiMul.lo(z,MAX);
                Claim.nonzero(h2);
                var l3 = MulOps.lo(z,MAX);
                Claim.eq(l3,l2);

                BmiMul.full(x,y, out uint a, out uint b);
                Claim.eq(lo, a);
                Claim.eq(hi, b);

                BmiMul.full(z,MAX, out uint c, out uint d);
                Claim.gt(c,0u);
                Claim.gt(d,0u);

                var c2 = (uint)(((ulong)z) * ((ulong)(MAX)));
                Claim.eq(c2, c);

            }
        }        

        public void mod_32()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var a = Random.Next<uint>();
                var actual = Mod32.mod(a);
                var expect = a % 32;
                Claim.eq(actual,expect);                
            }
        }

        public void div_32()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var a = Random.Next<uint>();                
                var actual = Mod32.div(a);
                var expect = a / 32;
                Claim.eq(actual,expect);                
            }
        }

        public void mul_64()
        {
            const ulong MAX = ulong.MaxValue;
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<ulong>(2, Pow2.T08);
                var y = Random.Next<ulong>(2, Pow2.T08);
                var z = Random.Next<ulong>(2, Pow2.T08);
            
                var lo = BmiMul.lo(x,y);
                Claim.eq(x*y,lo);

                var hi = MulOps.hi(x,y);
                Claim.eq(0,hi);

                Claim.nonzero(MulOps.hi(z,MAX));

                BmiMul.full(x,y, out ulong a, out ulong b);
                Claim.eq(lo, a);
                Claim.eq(hi, b);

                BmiMul.full(z,MAX, out ulong c, out ulong d);
                Claim.gt(c,0ul);
                Claim.gt(d,0ul);
            }
        }        

        public void mul_64_lo()
        {

            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<ulong>(uint.MaxValue, ulong.MaxValue);
                var b = Random.Next<ulong>(uint.MaxValue, ulong.MaxValue);
                Claim.eq(MulOps.lo(a,b), BmiMul.lo(a,b));
            }

        }

    }
}
