//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    

    public class t_vmask : t_vinx<t_vmask>
    {

        public void vsll8_128()
        {
            var w = n128;
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(w);
                for(byte shift = 1; shift < 8; shift++)                
                {
                    var actual = dinx.vsll8(x, shift);
                    var expect = mathspan.sll(x.ToSpan(), shift).LoadVector(w);
                    Claim.eq(actual,expect);
                }
            }
        }

        public void vsll8_256()
        {
            var w = n256;
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(w);
                for(byte shift = 1; shift < 8; shift++)                
                {
                    var actual = dinx.vsll8(x, shift);
                    var expect = mathspan.sll(x.ToSpan(), shift).LoadVector(w);
                    Claim.eq(actual,expect);
                }
            }
        }

        public void vsrl8_128()
        {
            var w = n128;
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(w);
                for(byte shift = 1; shift < 8; shift++)                
                {
                    var actual = dinx.vsrl8(x, shift);
                    var expect = mathspan.srl(x.ToSpan(), shift).LoadVector(w);
                    Claim.eq(actual,expect);
                }
            }
        }

        public void vsrl8_256()
        {
            var w = n256;
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(w);
                for(byte shift = 1; shift < 8; shift++)                
                {
                    var actual = dinx.vsrl8(x, shift);
                    var expect = mathspan.srl(x.ToSpan(), shift).LoadVector(w);
                    Claim.eq(actual,expect);
                }
            }
        }
        public void vsll8_basecase()
        {

            var w = n128;
            byte shift = 3;
            var x = Random.CpuVector<byte>(w);
            var actual = dinx.vsll8(x,shift);
            
            var xs = x.ToSpan();
            var es = DataBlocks.alloc<byte>(w);
            for(var i =0; i<xs.Length; i++)
                es[i] = gmath.sll(xs[i], shift);
            
            var expect = es.LoadVector();            
            Claim.eq(expect,actual);



        }

        public void vslr8_basecase()
        {

            var w = n128;
            byte shift = 3;
            var x = Random.CpuVector<byte>(w);
            var actual = dinx.vsrl8(x,shift);
            
            var xs = x.ToSpan();
            var es = DataBlocks.alloc<byte>(w);
            for(var i =0; i<xs.Length; i++)
                es[i] = gmath.srl(xs[i], shift);
            
            var expect = es.LoadVector();            
            Claim.eq(expect,actual);



        }


    }
}