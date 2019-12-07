//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bg_permute : t_bg<t_bg_permute>
    {        
        
        public void bg_permute_32x5()
        {
            var p = Perm.natural(n32);
            Claim.eq(p.Length,32);
            
            var g = BitGrid.perm(p);


        }
        public void bg_permute_16x4()
        {
            var identity = Perm16.Identity;
            var iterms = identity.Literals();
            var g1 = identity.ToBitGrid();
            var iperm = identity.ToNatural();            
            var g2 = iperm.ToBitGrid();
            Claim.yea(g1 == g2);

        
        }

        public void bg_permute_8x3()
        {
            var id = Perm8.Identity;
            var idterms = id.Literals();
            var g1 = id.ToBitGrid();
            var iperm = id.ToNatural();
            var g2 = iperm.ToBitGrid();
            //Claim.yea(g1 == g2);        
        }


        
    }
}