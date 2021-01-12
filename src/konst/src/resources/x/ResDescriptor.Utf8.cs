//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial class XTend
    {
        public static ReadOnlySpan<char> Utf8(this ResDescriptor src)
            => Resources.utf8(src);
    }
}