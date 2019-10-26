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

    public class t_vswaps : IntrinsicTest<t_vswaps>
    {
        
        public void perm_swaps()
        {            
            
            var src = Vec128Pattern.Increments((byte)0);

            Swap s = (0,1);
            var x1 = dinx.vswap(src, s);
            var x2 = dinx.vswap(x1, s);
            Claim.eq(x2, src);

            //Shuffle the first element all the way through to the last element
            var chain = Swap.Chain((0,1), 15);
            var x3 = dinx.vswap(src, chain).ToSpan();
            Claim.eq(x3[15],(byte)0);            
        }

    }
}