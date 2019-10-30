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
        void clmul128()
        {

            for(var i=0; i<DefaultSampleSize; i++)
            {
                var v1s = Random.BlockedSpan<ulong>(n128, UInt32.MinValue, UInt32.MaxValue);
                var v2s = Random.BlockedSpan<ulong>(n128, UInt32.MinValue, UInt32.MaxValue);
                var v1 = v1s.ToCpuVector();
                var v2 = v2s.ToCpuVector();

                UInt128 x00 = dinx.clmul(v1, v2, ClMulMask.X00);
                UInt128 x01 = dinx.clmul(v1, v2, ClMulMask.X01);
                UInt128 x10 = dinx.clmul(v1, v2, ClMulMask.X10);
                UInt128 x11 = dinx.clmul(v1, v2, ClMulMask.X11);

                var y00 = dinx.clmul(v1s[0], v2s[0]);
                Claim.eq(x00, y00);
                Claim.eq(x00, Bits.clmul_ref(v1s[0], v2s[0]));

                var y01 = dinx.clmul(v1s[1], v2s[0]);
                Claim.eq(x01, y01);
                Claim.eq(x01, Bits.clmul_ref(v1s[1], v2s[0]));

                var y10 = dinx.clmul(v1s[0], v2s[1]);
                Claim.eq(x10, y10);
                Claim.eq(x10, Bits.clmul_ref(v1s[0],v2s[1]));

                var y11 = dinx.clmul(v1s[1], v2s[1]);
                Claim.eq(x11, y11);
                Claim.eq(x11, Bits.clmul_ref(v1s[1], v2s[1]));
            }
        
        }
        
        public void mul256_u64()
        {
            void VerifyMul256u64(int blocks)
            {
                var domain = closed(0ul, UInt32.MaxValue);
                var lhs = Random.Span256<ulong>(blocks, domain);
                var rhs = Random.Span256<ulong>(blocks, domain);
                for(var block=0; block<blocks; block++)
                {
                    var x = ginxx.LoadVector(lhs, block);
                    var y = ginxx.LoadVector(rhs, block);
                    var z = dinx.vmul(x,y); 

                    var a = x.ToSpan().Replicate();
                    var b = y.ToSpan();
                    var c = mathspan.mul(a,b).LoadVector(n256);
                    Claim.eq(z,c);                                           
                }
            }

            VerifyMul256u64(DefaltCycleCount);
        }

        public void mul256u64_bench()
        {
            Collect(BaselineMul256u64());
            Collect(BenchmarkMul256u64());
        }

        public void umul64()
        {
            void VerifyUMul64(int samples)
            {
                var x = Random.Span<uint>(samples);
                var y = Random.Span<uint>(samples);
                for(var i=0; i< samples; i++)
                {
                    var xi = x[i];
                    var yi = y[i];
                    var z = (ulong)xi * (ulong)yi;
                    Claim.eq(z, UMul.mul(xi,yi));
                }
            }

            VerifyUMul64(Pow2.T12);
        }

        void VerifyUMul128Powers()
        {
            for(var i=0; i<=63; i++)
            for(var j=0; j<=63; j++)
            {
                var product = UMul.mul(1ul << i, 1ul << j, out UInt128 _);
                var bsExpect = BitString.FromPow2(i + j); 
                var bsActual = product.ToBitString();
                Trace($"{product.Format()}");
                Claim.eq(bsExpect,bsActual);                
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