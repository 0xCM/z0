//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;


    public class t_vabs : IntrinsicTest<t_vabs>
    {

        public void vabs_256x64()
        {
            abs64_check();
        }

        void abs64_check(int cycles = DefaltCycleCount)
        {
            for(var cycle = 0; cycle < cycles; cycle++)
            {
                var x = Random.CpuVector<long>(n256);            
                var actual = dinx.vabs(x);
                var expect = x.Map(Math.Abs);
                Claim.eq(expect, actual);
            }

            for(var cycle = 0; cycle < cycles; cycle++)
            {
                var x = Random.CpuVector<long>(n128);            
                var actual = dinx.vabs(x);
                var expect = x.Map(Math.Abs);
                Claim.eq(expect, actual);
            }

        }

    }

}