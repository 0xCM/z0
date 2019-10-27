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


    public class t_vabs : UnitTest<t_vabs>
    {

        public void vabs_256x64()
        {
            abs64_check();
        }

        void abs64_check(int cycles = DefaltCycleCount)
        {
            for(var cycle = 0; cycle < cycles; cycle++)
            {
                var x = Random.CpuVector256<long>();            
                var actual = dinx.abs(x);
                var expect = x.Map(Math.Abs);
                Claim.eq(expect, actual);
            }

            for(var cycle = 0; cycle < cycles; cycle++)
            {
                var x = Random.CpuVector128<long>();            
                var actual = dinx.abs(x);
                var expect = x.Map(Math.Abs);
                Claim.eq(expect, actual);
            }

        }

    }

}