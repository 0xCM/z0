//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bv_rank : BitVectorTest<t_bv_rank>
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

        public void gbv_rank_8()
            => bvrank_check<byte>();

        public void gbv_rank_16()
            => bvrank_check<ushort>();

        public void gbv_rank_32()
            => bvrank_check<uint>();

        public void bvrank_g64()
            => bvrank_check<ulong>();

        void bvrank_check<T>()
            where T : unmanaged
        {
            var x = Random.BitVector<T>();
            var pos = Random.Next(1,bitsize<T>() - 2);
            
            var actual = gbits.rank(x.Data,(uint)pos);
            var expect = 0u;
            for(var i=0; i<= pos; i++)
                expect += (x[i] ? 1u : 0u);
            Claim.eq(expect, actual);
        }    
    }
}