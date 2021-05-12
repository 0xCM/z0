//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class XTend
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Index<dynamic> Dynamify<T>(this Index<T> src)
            => src.Map(x => (dynamic)x);
    }
}