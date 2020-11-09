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

    [ApiHost(ApiNames.DataFlows, true)]
    public readonly struct DataFlows
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DataRef<T> reference<T>(in T src)
            where T : struct
                => new DataRef<T>(typeof(T).MetadataToken);
        public static TypeDependency<S,T> connect<S,T>()
            => default;

        [MethodImpl(Inline), Op]
        public static TypeDependency connect(Type src, Type dst)
            => (src,dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DataFlow<T[],BinaryCode> define<T>(T[] src, BinaryCode dst)
            where T : struct
                => z.paired(src,dst);

        [MethodImpl(Inline), Op]
        public static uint hash32(LinkType src)
            => hash(src.Source) ^ hash(src.Target) ^ hash(src.Kind);

        [MethodImpl(Inline), Op]
        public static ulong hash64(LinkType src)
            => hash(src.Kind, src.Source, src.Target);

        [MethodImpl(Inline), Op]
        public static bool eq(LinkType a, LinkType b)
            => a.Source == b.Source && a.Target == b.Target;

        [MethodImpl(Inline), Op]
        public static string format(LinkType t)
            => text.format("{0} -> {1}", t.Source.Name, t.Target.Name);

        [MethodImpl(Inline), Op]
        public static string format<S,T>(LinkType<S,T> t)
            => text.format("{0} -> {1}", t.Source.Name, t.Target.Name);

        [MethodImpl(Inline)]
        public static LinkType<S,T> type<S,T>(S s = default, T t = default)
            => new LinkType<S,T>(typeof(S),typeof(T));

        [MethodImpl(Inline), Op]
        public static LinkType type(Type src, Type dst)
            => new LinkType(src,dst);

        [MethodImpl(Inline)]
        public static string identify<S,T>(T src, S dst)
            => string.Format("{0} -> {1}", src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Link<T> link<T>(T src, T dst)
            => new Link<T>(src,dst);

        [MethodImpl(Inline)]
        public static Link<S,T> connect<S,T>(S src, T dst)
            => new Link<S,T>(src, dst);
    }
}