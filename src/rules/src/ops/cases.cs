//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Rules
    {
        [Op]
        public static SwitchCases<C,T> cases<C,T>(Index<C> cases, Index<T> targets)
        {
            var count = Require.equal(cases.Length, targets.Length);
            var dst = alloc<SwitchCase<C,T>>(count);
            for(var i=0u; i<count; i++)
                seek(dst,i) = new SwitchCase<C,T>(i, cases[i],targets[i]);
            return new SwitchCases<C,T>(dst);
        }
    }
}