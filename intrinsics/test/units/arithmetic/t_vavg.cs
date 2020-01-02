//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vavg : t_vinx<t_vavg>
    {     
        public void vavg_256x8u_check()
        {            
            for(var j=0; j < RepCount; j++)
            {
                var x = Random.CpuVector<byte>(n256);
                var y = Random.CpuVector<byte>(n256);
                var a = dinx.vavg(x,y).ToSpan();
                var b = mathspan.avgi(x.ToSpan(), y.ToSpan());
                for(var i=0; i< b.Length; i++)
                    Claim.eq(a[i], b[i]);
            }
        }

        public void vavg_256x16u_check()
        {            
            for(var j=0; j < RepCount; j++)
            {
                var x = Random.CpuVector<ushort>(n256);
                var y = Random.CpuVector<ushort>(n256);
                var a = dinx.vavg(x,y).ToSpan();
                var b = mathspan.avgi(x.ToSpan(), y.ToSpan());
                for(var i=0; i< b.Length; i++)
                    Claim.eq(a[i], b[i]);
            }
        }


    }

}
