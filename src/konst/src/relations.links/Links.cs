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

    [ApiHost(ApiNames.Links, true)]
    public readonly struct Links
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format(LinkType t)
            => text.format("{0} -> {1}", t.Source.Name, t.Target.Name);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(LinkType<T> src)
            => text.format("{0} -> {1}", src.Source.Name, src.Target.Name);

        [MethodImpl(Inline)]
        public static string format<S,T>(LinkType<S,T> src)
            => text.format("{0} -> {1}", src.Source.Name, src.Target.Name);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Link<T> link<T>(T src, T dst)
            => new Link<T>(src,dst);

        [MethodImpl(Inline)]
        public static Link<S,T> link<S,T>(S src, T dst)
            => new Link<S,T>(src, dst);

        [MethodImpl(Inline), Op]
        public static uint hash32(LinkType src)
            => hash(src.Source) ^ hash(src.Target) ^ hash(src.Kind);

        [MethodImpl(Inline), Op]
        public static ulong hash64(LinkType src)
            => hash(src.Kind, src.Source, src.Target);

        [MethodImpl(Inline), Op]
        public static bool eq(LinkType a, LinkType b)
            => a.Source == b.Source && a.Target == b.Target;

        [MethodImpl(Inline)]
        public static LinkType<T> type<T>(T t = default)
            => new LinkType<T>(typeof(T), typeof(T));

        [MethodImpl(Inline)]
        public static LinkType<S,T> type<S,T>(S s = default, T t = default)
            => new LinkType<S,T>(typeof(S),typeof(T));

        [MethodImpl(Inline), Op]
        public static LinkType type(Type src, Type dst)
            => new LinkType(src,dst);

        [MethodImpl(Inline)]
        public static string identifier<S,T>(T src, S dst)
            => string.Format("{0} -> {1}", src, dst);
    }
}