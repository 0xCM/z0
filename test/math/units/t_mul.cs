//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static Memories;


    public sealed class t_mul : UnitTest<t_mul>
    {
        protected override int RepCount => Pow2.T12;
        
        public void mul_2x32u()
        {
            const uint MAX = uint.MaxValue;
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<uint>(2, Pow2.T08);
                var y = Random.Next<uint>(2, Pow2.T08);
                var z = Random.Next<uint>(2, Pow2.T08);
            
                var lo = math.mullo(x,y);
                Claim.eq(x*y,lo);

                var hi = math.mulhi(x,y);
                Claim.eq(0,hi);

                math.mul(x,y, out uint a, out uint b);
                Claim.eq(lo, a);
                Claim.eq(hi, b);

                math.mul(z,MAX, out uint c, out uint d);
                ClaimNumeric.gt(c,0u);
                ClaimNumeric.gt(d,0u);

                var c2 = (uint)(((ulong)z) * ((ulong)(MAX)));
                Claim.eq(c2, c);
            }

            for(var i=0; i< RepCount; i++)
            {
                var xi = Random.Next<uint>();
                var yi = Random.Next<uint>();
                var z = (ulong)xi * (ulong)yi;
                Claim.eq(z, math.mul64(xi,yi));
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

        public void mul_2x64u()
        {
            const ulong MAX = ulong.MaxValue;
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<ulong>(2, Pow2.T08);
                var y = Random.Next<ulong>(2, Pow2.T08);
                var z = Random.Next<ulong>(2, Pow2.T08);
            
                var lo = math.mullo(x,y);
                Claim.eq(x*y,lo);

                var hi = math.mulhi(x,y);
                Claim.eq(0,hi);

                ClaimNumeric.nonzero(math.mulhi(z,MAX));

                math.mul(x,y, out ulong a, out ulong b);
                Claim.eq(lo, a);
                Claim.eq(hi, b);

                math.mul(z,MAX, out ulong c, out ulong d);
                ClaimNumeric.gt(c,0ul);
                ClaimNumeric.gt(d,0ul);
            }
        }        

        public static ulong lo_ref(ulong x, ulong y)
            => x*y;
        public void mullo_2x64u()
        {

            for(var i=0; i< RepCount; i++)
            {
                var a = Random.Next<ulong>(uint.MaxValue, ulong.MaxValue);
                var b = Random.Next<ulong>(uint.MaxValue, ulong.MaxValue);
                Claim.eq(lo_ref(a,b), math.mullo(a,b));
            }

        }
    }
}