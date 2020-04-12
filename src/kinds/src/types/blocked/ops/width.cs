//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    partial class BlockedTypeKinds
    {
        public static TypeWidth width(Type src)
            => Widths.blocked(src);
    }
}