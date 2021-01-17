//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void apply<T>(Replacement<T> rule, ReadOnlySpan<T> src, Span<T> dst, int offset = 0)
            where T : unmanaged, IEquatable<T>
        {
            var count = src.Length;
            var input = span(src);
            fixed(T* c = src)
                for(var i=offset; i<count; i++)
                    seek(dst,i) = (*c).Equals(rule.Match) ? rule.Replace : skip(input,i);
        }
    }
}