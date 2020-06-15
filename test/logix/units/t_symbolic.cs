//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Konst;

    public class t_symbolic : UnitTest<t_symbolic>
    {

        public void render_2()
        {
            var src = Random.Bytes(8).ToSpan();
            var actual = Symbolic.render(Seed.base2, src).ToString();
            var expect = src.ToBitSpan().Format();
            ClaimPrimal.eq(expect,actual);

        }

    }
}
