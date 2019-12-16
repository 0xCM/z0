//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vsrl : t_vinx<t_vsrl>
    {
        public void vsrl_128x8u()
            => vsrl_check<byte>(n128);

        public void vsrl_128x16u()
            => vsrl_check<ushort>(n128);

        public void vsrl_128x32u()
            => vsrl_check<uint>(n128);

        public void vsrl_128x64u()
            => vsrl_check<ulong>(n128);

        public void vsrl_256x8u()
            => vsrl_check<byte>(n256);

        public void vsrl_256x16u()
            => vsrl_check<ushort>(n256);

        public void vsrl_256x32u()
            => vsrl_check<uint>(n256);

        public void vsrl_256x64u()
            => vsrl_check<ulong>(n256);

        public void vsrl_128x8u_bench()
            => vsrl_bench<byte>(n128);

        public void vsrl_128x16u_bench()
            => vsrl_bench<ushort>(n128);

        public void vsrl_128x32u_bench()
            => vsrl_bench<uint>(n128);

        public void vsrl_128x64u_bench()
            => vsrl_bench<ulong>(n128);

        public void vsrl_256x8u_bench()
            => vsrl_bench<byte>(n256);

        public void vsrl_256x16u_bench()
            => vsrl_bench<ushort>(n256);

        public void vsrl_256x32u_bench()
            => vsrl_bench<uint>(n256);

        public void vsrl_256x64u_bench()
            => vsrl_bench<ulong>(n256);
 
        public void t_vsrl_128x8u_outline()
        {
            var w = n128;
            byte shift = 3;
            var x = Random.CpuVector<byte>(w);
            var actual = dinx.vsrl(x,shift);
            
            var xs = x.ToSpan();
            var es = DataBlocks.single<byte>(w);
            for(var i =0; i<xs.Length; i++)
                es[i] = gmath.srl(xs[i], shift);
            
            var expect = es.LoadVector();            
            Claim.eq(expect,actual);
        }

        public void t_vrll_128x8_alt()
        {
            var w = n128;
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(w);
                for(byte shift = 1; shift < 8; shift++)                
                {
                    var actual = dinx.vsrl(x, shift);
                    var expect = mathspan.srl(x.ToSpan(), shift).LoadVector(w);
                    Claim.eq(actual,expect);
                }
            }
        }

        public void t_vsrl_256x8_alt()
        {
            var w = n256;
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(w);
                for(byte shift = 1; shift < 8; shift++)                
                {
                    var actual = dinx.vsrl(x, shift);
                    var expect = mathspan.srl(x.ToSpan(), shift).LoadVector(w);
                    Claim.eq(actual,expect);
                }
            }
        }     
    }
}