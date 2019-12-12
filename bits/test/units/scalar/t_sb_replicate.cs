//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_sb_replicate : t_sb<t_sb_replicate>
    {                
        public void sb_replicate_32uMod64()
        {
            var src = 0b111000u;
            var actual = gbits.replicate(n64,src);
            var width = gbits.width(src);
            Claim.eq(6,width);

            var expect = BitVector.alloc(n32);
            for(int i=0; i< expect.Width; i++)
                if(math.between( i % 6,3,5))
                    expect[i] = bit.On;
            
            Claim.eq(expect,actual);
        }

        public void sb_replicate_64uMod64()
        {

            var src = 0b111000ul;
            var actual = gbits.replicate(n64,src);

            var width = gbits.width(src);
            Claim.eq(6,width);
            
            var expect = BitVector.alloc(n64);
            for(int i=0; i< expect.Width; i++)
                if(math.between( i % 6,3,5))
                    expect[i] = bit.On;

            Claim.eq(expect, actual);


            void report()
            {
                Trace("expect", bracket(expect.Format(6)));
                Trace("actual", actual.FormatBitBlocks(6));
            }
        }
    }
}