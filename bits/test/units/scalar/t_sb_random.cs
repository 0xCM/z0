//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_sb_random : t_sb<t_sb_random>
    {            

        public void bitspan_rand_check()
        {
            var dst = span<bit>(1024);
            var on = 0;
            var off = 0;
            for(var j = 0; j < Pow2.T04; j++)
            {
                Random.Fill(dst);
                for(var i=0; i<dst.Length; i++)
                    if(dst[i]) 
                        on++; 
                    else 
                        off++;                
            }
            var ratio = fmath.div(on,off);
            var error = fmath.abs(ratio - 1.0f);
            Claim.lt(error,.1);            
        }

    }

}