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

    using static Seed;
    using static Memories;

    public class t_symbolic : UnitTest<t_symbolic>
    {

        public void render_2()
        {
            var src = Random.Bytes(8).ToSpan();
            var actual = Symbolic.render(base2, src).ToString();
            var expect = src.ToBitSpan().Format();
            Primal.eq(expect,actual);

        }

    }
}
