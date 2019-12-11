//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_sclmul : t_sinx<t_sclmul>
    {

        //Cant get this to check
        void pop_count_check()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector<ushort>(n256);
                var expect = AvxPops.pop64(x);
                var actual = AvxPops.avxpop(x);
                
                Trace($"expect {expect}, actual {actual.Format()}");
                if(i == 3)
                    break;

            }
        }

        public void clmul_8u()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<byte>();
                var y = Random.Next<byte>();
                var poly = GfPoly.Lookup<N8,ushort>().Scalar;

                var z1 = Cl.clmulr8u(x,y,poly);
                var z2 = dinx.clmulr(x,y,poly);
                Claim.eq(z1,z2);
            }
            
        }
    }
}