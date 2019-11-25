//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_pbv_rank : t_bv<t_pbv_rank>
    {
        public void pbv_rank_8()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n8);
                var pos = Random.Next(1,6);
                
                var actual = gbits.rank(x.Scalar,(uint)pos);
                var expect = 0u;
                for(var j=0; j<= pos; j++)
                    expect += (x[j] ? 1u : 0u);
                Claim.eq(expect, actual);
            }
        }            

        public void pbv_rank_32()
        {
            for(var i=0; i<SampleSize; i++)
            {            
                var x = Random.BitVector(n32);
                var pos = Random.Next(1,28);
                
                var actual = gbits.rank(x.Scalar,(uint)pos);
                var expect = 0u;
                for(var j=0; j<= pos; j++)
                    expect += (x[j] ? 1u : 0u);
                Claim.eq(expect, actual);
            }
        }        

        public void pbv_rank_64()
        {
            for(var i=0; i<SampleSize; i++)
            {
            
                var x = Random.BitVector(n64);
                var pos = Random.Next(1,50);
                
                var actual = gbits.rank(x.Scalar,(uint)pos);
                var expect = 0u;
                for(var j=0; j<= pos; j++)
                    expect += (x[j] ? 1u : 0u);
                Claim.eq(expect, actual);
            }
        }        


    }
}