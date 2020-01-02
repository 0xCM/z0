//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bv_rank : t_bv<t_bv_rank>
    {
        public void gbv_rank_8()
            => gbv_rank_check<byte>();

        public void gbv_rank_16()
            => gbv_rank_check<ushort>();

        public void gbv_rank_32()
            => gbv_rank_check<uint>();

        public void gbv_rank_64()
            => gbv_rank_check<ulong>();

        public void pbv_rank_8()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.BitVector(n8);
                var pos = Random.Next(1,6);
                
                var actual = gbits.rank(x.Scalar,pos);
                var expect = 0u;
                for(var j=0; j<= pos; j++)
                    expect += (x[j] ? 1u : 0u);
                Claim.eq(expect, actual);
            }
        }            

        public void pbv_rank_32()
        {
            for(var i=0; i<RepCount; i++)
            {            
                var x = Random.BitVector(n32);
                var pos = Random.Next(1,28);
                
                var actual = gbits.rank(x.Scalar,pos);
                var expect = 0u;
                for(var j=0; j<= pos; j++)
                    expect += (x[j] ? 1u : 0u);
                Claim.eq(expect, actual);
            }
        }        

        public void pbv_rank_64()
        {
            for(var i=0; i<RepCount; i++)
            {
            
                var x = Random.BitVector(n64);
                var pos = Random.Next(1,50);
                
                var actual = gbits.rank(x.Scalar,pos);
                var expect = 0u;
                for(var j=0; j<= pos; j++)
                    expect += (x[j] ? 1u : 0u);
                Claim.eq(expect, actual);
            }
        }        


    }
}