//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    partial struct SpanRes
    {
        public static ReadOnlySpan<ReflectedByteSpan> reflected(Type[] src)
            => Clr.bytespans(src);
    }
}