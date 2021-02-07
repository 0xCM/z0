//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct root
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T ifnull<T>(T input, T replace)
            => input ?? replace;
    }
}