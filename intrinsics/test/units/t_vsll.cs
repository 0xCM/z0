//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vsll : t_vinx<t_vsll>
    {

        public void vsll_128x8u()
            => vsll_check(n128,z8);

        public void vsll_128x16u()
            => vsll_check(n128,z16);

        public void vsll_128x32u()
            => vsll_check(n128,z32);

        public void vsll_128x64u()
            => vsll_check(n128,z64);

        public void vsll_256x8u()
            => vsll_check(n256,z8);

        public void vsll_256x16u()
            => vsll_check(n256,z16);

        public void vsll_256x32u()
            => vsll_check(n256,z32);

        public void vsll_256x64u()
            => vsll_check(n256,z64);


        public void t_vsll_128x8u_outline()
        {
            var w = n128;
            byte shift = 3;
            var x = Random.CpuVector<byte>(w);
            var actual = dinx.vsll(x,shift);
            
            var xs = x.ToSpan();
            var es = DataBlocks.single<byte>(w);
            for(var i =0; i<xs.Length; i++)
                es[i] = gmath.sll(xs[i], shift);
            
            var expect = es.LoadVector();            
            Claim.eq(expect,actual);
        }

        public void t_vsll_128x8_alt()
        {
            var w = n128;
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(w);
                for(byte shift = 1; shift < 8; shift++)                
                {
                    var actual = dinx.vsll(x, shift);
                    var expect = mathspan.sll(x.ToSpan().ReadOnly(), shift).LoadVector(w);
                    Claim.eq(actual,expect);
                }
            }
        }

        public void t_vsll_256x8_alt()
        {
            var w = n256;
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(w);
                for(byte shift = 1; shift < 8; shift++)                
                {
                    var actual = dinx.vsll(x, shift);
                    var expect = mathspan.sll(x.ToSpan().ReadOnly(), shift).LoadVector(w);
                    Claim.eq(actual,expect);
                }
            }
        }
    }
}