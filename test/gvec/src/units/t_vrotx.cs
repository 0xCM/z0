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
                var x = gcpu.vunits<byte>(n128);
                Claim.veq(gcpu.vrotrx(x,8), cpu.vrotrx(x,n8));
                Claim.veq(gcpu.vrotrx(x,16), cpu.vrotrx(x,n16));
                Claim.veq(gcpu.vrotrx(x,24), cpu.vrotrx(x,n24));
                Claim.veq(gcpu.vrotrx(x,32), cpu.vrotrx(x,n32));
            }
        }

        public void vrotlx_128x8u()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = gcpu.vunits<byte>(n128);
                Claim.veq(gcpu.vrotlx(x,8), cpu.vrotlx(x,n8));
                Claim.veq(gcpu.vrotlx(x,16), cpu.vrotlx(x,n16));
                Claim.veq(gcpu.vrotlx(x,24), cpu.vrotlx(x,n24));
                Claim.veq(gcpu.vrotlx(x,32), cpu.vrotlx(x,n32));
            }
        }
    }
}