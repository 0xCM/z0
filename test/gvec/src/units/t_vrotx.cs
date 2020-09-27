//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    public class t_vrotx : t_inx<t_vrotx>
    {
        public void vrotrx_128x8u()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = vunits<byte>(n128);
                Claim.veq(gvec.vrotrx(x,8), z.vrotrx(x,n8));
                Claim.veq(gvec.vrotrx(x,16), z.vrotrx(x,n16));
                Claim.veq(gvec.vrotrx(x,24), z.vrotrx(x,n24));
                Claim.veq(gvec.vrotrx(x,32), z.vrotrx(x,n32));
            }
        }

        public void vrotlx_128x8u()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = vunits<byte>(n128);
                Claim.veq(gvec.vrotlx(x,8), z.vrotlx(x,n8));
                Claim.veq(gvec.vrotlx(x,16), z.vrotlx(x,n16));
                Claim.veq(gvec.vrotlx(x,24), z.vrotlx(x,n24));
                Claim.veq(gvec.vrotlx(x,32), z.vrotlx(x,n32));
            }
        }
    }
}