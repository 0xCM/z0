//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Index
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> delimit<T>(Index<T> src, char delimiter = Chars.Comma, int pad = 0)
            => new DelimitedIndex<T>(src, delimiter, pad);
    }
}
