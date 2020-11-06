//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.Relations, true)]
    public readonly struct Relations
    {
        [MethodImpl(Inline)]
        internal static void project<S,T>(ReadOnlySpan<S> a, ReadOnlySpan<T> b, Span<Paired<S,T>> dst)
        {
            var count = dst.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = paired(skip(a,i), skip(b,i));
        }
    }
}