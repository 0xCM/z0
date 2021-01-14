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
        public static T FirstOrDefault<T>(this Index<T> src, T @default = default)
            => Index.firstOrDefault(src, @default);
    }
}