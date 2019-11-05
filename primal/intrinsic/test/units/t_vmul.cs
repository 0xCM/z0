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

            }
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