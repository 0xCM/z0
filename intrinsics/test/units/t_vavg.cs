//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
            for(var j=0; j < SampleCount; j++)
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
            for(var j=0; j < SampleCount; j++)
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
                for(var i=0; i<SampleCount; i++)
                {
                    var x = Random.Blocks<byte>(n256);
                    var y = Random.Blocks<byte>(n256);
                    sw.Start();
                    var b = mathspan.avgi(x.ReadOnly(), y.ReadOnly());
                    sw.Stop();
                }
                return OpTime.Define<byte>(SampleCount, sw, $"vavg-ref");
            }

            OpTime opbench()
            {
                var sw = stopwatch(false);
                for(var i=0; i<SampleCount; i++)
                {
                    var x = Random.CpuVector<byte>(n256);
                    var y = Random.CpuVector<byte>(n256);
                    sw.Start();
                    var a = dinx.vavg(x,y);
                    sw.Stop();
                }
                return OpTime.Define<byte>(SampleCount, sw, $"vavg");        

            }

            if(reference)
                return refbench();
            else
                return opbench();
        }

    }

}
