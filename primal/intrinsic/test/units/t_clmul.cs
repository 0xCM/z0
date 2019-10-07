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
    using System.IO;
    
    using static zfunc;
    using static nfunc;

    public class t_clmul : IntrinsicTest<t_clmul>
    {

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