//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;    

    public class t_vrotx : t_vinx<t_vrotx>
    {
        public void vrotrx_128x8u()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = CpuVector.vunits<byte>(n128);            
                Claim.eq(ginx.vrotrx(x,8), dinx.vrotrx(x,n8));
                Claim.eq(ginx.vrotrx(x,16), dinx.vrotrx(x,n16));
                Claim.eq(ginx.vrotrx(x,24), dinx.vrotrx(x,n24));
                Claim.eq(ginx.vrotrx(x,32), dinx.vrotrx(x,n32));
            }

        }

        public void vrotlx_128x8u()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = CpuVector.vunits<byte>(n128);            
                Claim.eq(ginx.vrotlx(x,8), dinx.vrotlx(x,n8));
                Claim.eq(ginx.vrotlx(x,16), dinx.vrotlx(x,n16));
                Claim.eq(ginx.vrotlx(x,24), dinx.vrotlx(x,n24));
                Claim.eq(ginx.vrotlx(x,32), dinx.vrotlx(x,n32));
            }
        }


    }
}