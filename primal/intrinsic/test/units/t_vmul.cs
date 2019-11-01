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
    using System.Runtime.Intrinsics;
    using System.IO;
    
    using static zfunc;

    public class tv_mul : UnitTest<tv_mul>
    {

        public void mul256_u64()
        {
            var n = n256;
            for(var sample=0; sample < SampleSize; sample++)
            {
                var x = Random.CpuVector<ulong>(n, 0, uint.MaxValue);
                var y = Random.CpuVector<ulong>(n, 0, uint.MaxValue);
                var z = dinx.vmul(x,y); 

                var a = x.ToSpan();
                var b = y.ToSpan();
                var c = z.ToSpan();
                for(var i=0; i< c.Length; i++)
                    Claim.eq(a[i]*b[i], c[i]);
            }
        }

        public void mul256u64_bench()
        {
            Collect(BaselineMul256u64());
            Collect(BenchmarkMul256u64());
        }

        public void umul64_check()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var xi = Random.Next<uint>();
                var yi = Random.Next<uint>();
                var z = (ulong)xi * (ulong)yi;
                Claim.eq(z, UMul.mul(xi,yi));
            }
        }

        OpTime BenchmarkMul256u64()
        {
            var sw = stopwatch(false);
            var domain = closed(0ul, UInt32.MaxValue);            
            var counter = 0;

            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector256(domain);
                var y = Random.CpuVector256(domain);
                sw.Start();
                var z = dinx.vmul(x,y);
                sw.Stop();
                counter += 4;
            }

            return (counter, snapshot(sw),"mul256u64:benchmark");
        }

        OpTime BaselineMul256u64()
        {
            var sw = stopwatch(false);
            var domain = closed(0ul, UInt32.MaxValue);            
            var counter = 0;
            Span<ulong> last = default;
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Span(4, domain);
                var y = Random.Span(4, domain);
                sw.Start();
                last = mathspan.mul(x, y);
                sw.Stop();
                counter += 4;
            }

            return (counter, snapshot(sw),"mul256u64:baseline");        
        }

    }
}