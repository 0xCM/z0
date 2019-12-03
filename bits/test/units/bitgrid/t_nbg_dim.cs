//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using static zfunc;
    
    public class t_nbg_dim : t_bg<t_nbg_dim>
    {        

        public void nbg_dimensions()
        {

            var d256a = BitGrid.dimensions(Pow2.T08).OrderBy(x =>x.I).ThenBy(x => x.J).ToArray();
            var d256b = BitGrid.dimensions(n256).OrderBy(x =>x.I).ThenBy(x => x.J).ToArray();
            for(var i=0; i< length(d256a,d256b); i++)
            {
                Claim.eq(d256a[i].I, d256b[i].I);
                Claim.eq(d256a[i].J, d256b[i].J);
            }
            
            var d128a = BitGrid.dimensions(Pow2.T07).OrderBy(x =>x.I).ThenBy(x => x.J).ToArray();
            var d128b = BitGrid.dimensions(n128).OrderBy(x =>x.I).ThenBy(x => x.J).ToArray();
            for(var i=0; i< length(d128a,d128b); i++)
            {
                Claim.eq(d128a[i].I, d128b[i].I);
                Claim.eq(d128a[i].J, d128b[i].J);
            }
            
        }

    }

}