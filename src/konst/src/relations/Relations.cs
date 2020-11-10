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

        [MethodImpl(Inline)]
        public static string format<T>(Dependency<T> src)
            where T : INode<T>
                => text.format("{0} -> {1}", src.Source, src.Target);

        [MethodImpl(Inline)]
        public static string format<S,T>(Dependency<S,T> src)
            where S : INode<S>
            where T : INode<T>
                => text.format("{0} -> {1}", src.Source, src.Target);
    }
}