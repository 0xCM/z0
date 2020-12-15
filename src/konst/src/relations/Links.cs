//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.Links, true)]
    public readonly struct Links
    {
        const NumericKind Closure = UnsignedInts;

        [Op, Closures(Closure)]
        public static string format(LinkType t)
            => Relations.RenderLink<string>().Format(t.Source.Name, t.Target.Name);

        [Op, Closures(Closure)]
        public static string format<T>(LinkType<T> src)
            => Relations.RenderLink<string>().Format(src.Source.Name, src.Target.Name);

        public static string format<S,T>(LinkType<S,T> src)
            => Relations.RenderLink<string>().Format(src.Source.Name, src.Target.Name);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Link<T> link<T>(T src, T dst)
            => new Link<T>(src,dst);

        /// <summary>
        /// Defines a link from a source to a target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">THe target</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Link<S,T> link<S,T>(S src, T dst)
            => new Link<S,T>(src, dst);

        [MethodImpl(Inline)]
        public static Link<S,T,K> link<S,T,K>(S src, T dst, K kind)
            where K : unmanaged
                => new Link<S,T,K>(src, dst, kind);

        [MethodImpl(Inline), Op]
        public static uint hash32(LinkType src)
            => alg.hash.calc(src.Source) ^ alg.hash.calc(src.Target) ^ alg.hash.calc(src.Kind);

        [MethodImpl(Inline), Op]
        public static ulong hash64(LinkType src)
            => alg.hash.calc(src.Kind, src.Source, src.Target);

        [MethodImpl(Inline), Op]
        public static bool eq(LinkType a, LinkType b)
            => a.Source == b.Source && a.Target == b.Target;

        [MethodImpl(Inline)]
        public static LinkType type<T>(T t = default)
            => new LinkType<T>(typeof(T), typeof(T));

        [MethodImpl(Inline), Op]
        public static LinkType type(Type src, Type dst)
            => new LinkType(src,dst);

        [MethodImpl(Inline), Op]
        public static LinkType type(Type src, Type dst, Type kind)
            => new LinkType(src,dst, kind);

        [MethodImpl(Inline)]
        public static LinkType type<S,T>()
            => new LinkType<S,T>(typeof(S), typeof(T));

        [MethodImpl(Inline)]
        public static LinkType type<S,T,K>()
            where K : unmanaged
                => new LinkType<S,T,K>(typeof(S), typeof(T), typeof(K));

        [MethodImpl(Inline)]
        public static string identifier<S,T>(Link<S,T> link)
            => Relations.RenderLink<S,T>().Format(link.Source, link.Target);

        [MethodImpl(Inline), Closures(Closure)]
        public static string identifier<T>(Link<T> link)
            => Relations.RenderLink<T>().Format(link.Source, link.Target);
    }
}