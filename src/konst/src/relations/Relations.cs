//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost(ApiNames.Relations, true)]
    public readonly struct Relations
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Node<T> node<T>(T src)
            => new Node<T>(src);

        [MethodImpl(Inline)]
        public static void project<S,T>(ReadOnlySpan<S> a, ReadOnlySpan<T> b, Span<Paired<S,T>> dst)
        {
            var count = dst.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = paired(skip(a,i), skip(b,i));
        }

        [MethodImpl(Inline)]
        public static Isomorphic<S,T> isomorphic<S,T>(S src, T dst)
            => default;

        [MethodImpl(Inline)]
        public static Isomorphic isomorphic(Type src, Type dst)
            => new Isomorphic(src, dst);

        [MethodImpl(Inline)]
        public static string format<T>(Dependency<T> src)
            => RenderLink<T>().Format(src.Source, src.Target);

        [MethodImpl(Inline)]
        public static string format<S,T>(Dependency<S,T> src)
            => RenderLink<S,T>().Format(src.Source, src.Target);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Bijection<T> bijection<T>(T[] src, T[] dst)
            => new Bijection<T>(src,dst);

        [MethodImpl(Inline)]
        public static Bijection<S,T> bijection<S,T>(S[] src, T[] dst)
            => new Bijection<S,T>(src,dst);

        public static RenderPattern<S,T> RenderLink<S,T>() => "{0} -> {1}";

        public static RenderPattern<T,T> RenderLink<T>() => RenderLink<T,T>();
    }
}