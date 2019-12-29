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
        protected override int RepCount => Pow2.T12;
        
        public void mul_32()
        {
            const uint MAX = uint.MaxValue;
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<uint>(2, Pow2.T08);
                var y = Random.Next<uint>(2, Pow2.T08);
                var z = Random.Next<uint>(2, Pow2.T08);
            
                var lo = Math128.mullo(x,y);
                Claim.eq(x*y,lo);

                var hi = Math128.mulhi(x,y);
                Claim.eq(0,hi);

                Math128.mul(x,y, out uint a, out uint b);
                Claim.eq(lo, a);
                Claim.eq(hi, b);

                Math128.mul(z,MAX, out uint c, out uint d);
                Claim.gt(c,0u);
                Claim.gt(d,0u);

                var c2 = (uint)(((ulong)z) * ((ulong)(MAX)));
                Claim.eq(c2, c);

            }
        }        

        public void mod_32()
        {
            for(var i=0; i<RepCount; i++)
            {
                var a = Random.Next<uint>();
                var actual = Mod32.mod(a);
                var expect = a % 32;
                Claim.eq(actual,expect);                
            }
        }

        public void div_32()
        {
            for(var i=0; i<RepCount; i++)
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
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<ulong>(2, Pow2.T08);
                var y = Random.Next<ulong>(2, Pow2.T08);
                var z = Random.Next<ulong>(2, Pow2.T08);
            
                var lo = Math128.mullo(x,y);
                Claim.eq(x*y,lo);

                var hi = Math128.mulhi(x,y);
                Claim.eq(0,hi);

                Claim.nonzero(Math128.mulhi(z,MAX));

                Math128.mul(x,y, out ulong a, out ulong b);
                Claim.eq(lo, a);
                Claim.eq(hi, b);

                Math128.mul(z,MAX, out ulong c, out ulong d);
                Claim.gt(c,0ul);
                Claim.gt(d,0ul);
            }
        }        

        public void mul_64_lo()
        {

            for(var i=0; i< RepCount; i++)
            {
                var a = Random.Next<ulong>(uint.MaxValue, ulong.MaxValue);
                var b = Random.Next<ulong>(uint.MaxValue, ulong.MaxValue);
                Claim.eq(Math128.lo_ref(a,b), Math128.mullo(a,b));
            }

        }

    }
}
