//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bvrev : BitVectorTest<t_bvrev>
    {
        public void bvrev_check()
        {
            for(var sample=0; sample<SampleSize; sample++)
            {
                var bs = Random.BitString(n20);
                var block1 = bs.Replicate().ToBitBlock(n20);
                block1.Reverse();
                bs.Reverse();
                for(var j=0; j<bs.Length; j++)
                    Claim.yea( bs[j] == block1[j]);
                            
            }
        }

    }

}