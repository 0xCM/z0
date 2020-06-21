//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class t_symbolic : UnitTest<t_symbolic>
    {

        public void render_2()
        {
            var src = Random.Bytes(8).ToSpan();
            var actual = asci.render(Konst.base2, src).ToString();
            var expect = src.ToBitSpan().Format();
            ClaimPrimal.eq(expect,actual);

        }

    }
}
