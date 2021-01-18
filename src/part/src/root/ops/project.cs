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

    partial struct root
    {
        [MethodImpl(Inline)]
        public static void project<S,T>(ReadOnlySpan<S> a, ReadOnlySpan<T> b, Span<Paired<S,T>> dst)
        {
            var count = dst.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = root.paired(skip(a,i), skip(b,i));
        }
    }
}