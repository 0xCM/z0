//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Seed;
    using static Memories;

    public class t_vrotx : t_inx<t_vrotx>
    {
        public void vrotrx_128x8u()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Data.vunits<byte>(n128);            
                Claim.veq(gvec.vrotrx(x,8), dvec.vrotrx(x,n8));
                Claim.veq(gvec.vrotrx(x,16), dvec.vrotrx(x,n16));
                Claim.veq(gvec.vrotrx(x,24), dvec.vrotrx(x,n24));
                Claim.veq(gvec.vrotrx(x,32), dvec.vrotrx(x,n32));
            }
        }

        public void vrotlx_128x8u()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Data.vunits<byte>(n128);            
                Claim.veq(gvec.vrotlx(x,8), dvec.vrotlx(x,n8));
                Claim.veq(gvec.vrotlx(x,16), dvec.vrotlx(x,n16));
                Claim.veq(gvec.vrotlx(x,24), dvec.vrotlx(x,n24));
                Claim.veq(gvec.vrotlx(x,32), dvec.vrotlx(x,n32));
            }
        }
    }
}