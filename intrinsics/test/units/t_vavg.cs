//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vavg : IntrinsicTest<t_vavg>
    {     
        public void vavg_256x8u_check()
        {            
            for(var j=0; j < SampleSize; j++)
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
            for(var j=0; j < SampleSize; j++)
            {
                var x = Random.CpuVector<ushort>(n256);
                var y = Random.CpuVector<ushort>(n256);
                var a = dinx.vavg(x,y).ToSpan();
                var b = mathspan.avgi(x.ToSpan(), y.ToSpan());
                for(var i=0; i< b.Length; i++)
                    Claim.eq(a[i], b[i]);
            }
        }

        public void vavg_256x8u_bench()
        {
            Collect(avg_bench(true));
            Collect(avg_bench(false));
        }

        OpTime avg_bench(bool reference)
        {

            OpTime refbench()        
            {
                var sw = stopwatch(false);
                for(var i=0; i<SampleSize; i++)
                {
                    var x = Random.BlockedSpan<byte>(n256);
                    var y = Random.BlockedSpan<byte>(n256);
                    sw.Start();
                    var b = mathspan.avgi(x, y);
                    sw.Stop();
                }
                return OpTime.Define<byte>(SampleSize, sw, $"vavg-ref");
            }

            OpTime opbench()
            {
                var sw = stopwatch(false);
                for(var i=0; i<SampleSize; i++)
                {
                    var x = Random.CpuVector<byte>(n256);
                    var y = Random.CpuVector<byte>(n256);
                    sw.Start();
                    var a = dinx.vavg(x,y);
                    sw.Stop();
                }
                return OpTime.Define<byte>(SampleSize, sw, $"vavg");        

            }

            if(reference)
                return refbench();
            else
                return opbench();
        }

    }

}
