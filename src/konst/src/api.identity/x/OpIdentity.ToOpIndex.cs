//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class XTend
    {
        public static ApiOpIndex<T> ToOpIndex<T>(this IEnumerable<(OpIdentity,T)> src, bool deduplicate = true)
            => ApiIdentity.index(src,deduplicate);
    }
}