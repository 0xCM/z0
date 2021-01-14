//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XIndex
    {
        [MethodImpl(Inline)]
        public static bool Any<T>(this Index<T> src)
            => Index.any(src);
    }
}