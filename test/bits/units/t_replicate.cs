//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public class t_replicate : t_bitcore<t_replicate>
    {                
        public void replicate_8x32()
        {
            for(var i=0; i<RepCount; i++)
            {
                var pattern = Random.Next(z8);
                (var x0, var x1, var x2, var x3) = Bits.split(gbits.replicate<uint>(pattern),n4);
                Claim.Eq(x0, pattern);
                Claim.Eq(x1, pattern);
                Claim.Eq(x2, pattern);
                Claim.Eq(x3, pattern);                
            }
        }

        public void replicate_32u()
        {
            var src = 0b111000u;
            var actual = gbits.replicate(src).ToBitVector();
            var width = gbits.effwidth(src);
            Claim.eq(6,width);

            var expect = BitVector.alloc(n32);
            for(int i=0; i< expect.Width; i++)
                if(math.between( i % 6,3,5))
                    expect[i] = bit.On;
            
            Claim.Eq(expect.Scalar,actual.Scalar);
        }

        public void replicate_64u()
        {

            var src = 0b111000ul;
            var actual = gbits.replicate(src).ToBitVector();

            var width = gbits.effwidth(src);
            Claim.eq(6,width);
            
            var expect = BitVector.alloc(n64);
            for(int i=0; i< expect.Width; i++)
                if(math.between( i % 6,3,5))
                    expect[i] = bit.On;
            
            Claim.Eq(expect.Scalar,actual.Scalar);

            void report()
            {
                Trace("expect", text.bracket(expect.Format(6)));
                Trace("actual", actual.FormatBlocked(6));
            }
        }
    }
}