//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct root
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lazy<T> lazy<T>(Func<T> f)
            => new Lazy<T>(f);
    }
}