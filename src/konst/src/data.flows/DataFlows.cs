//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct DataFlows
    {
        [MethodImpl(Inline), Op]
        public static uint hash32(ArrowType src)
            => z.hash(src.Source) ^ z.hash(src.Target) ^ z.hash(src.Kind);

        [MethodImpl(Inline), Op]
        public static ulong hash64(ArrowType src)
            => z.hash(src.Kind, src.Source, src.Target);

        [MethodImpl(Inline), Op]
        public static bool eq(ArrowType a, ArrowType b)
            => a.Source == b.Source && a.Target == b.Target;

        [MethodImpl(Inline), Op]
        public static string format(ArrowType t)
            => text.format("{0} -> {1}", t.Source.Name, t.Target.Name);

        [MethodImpl(Inline), Op]
        public static string format<S,T>(ArrowType<S,T> t)
            => text.format("{0} -> {1}", t.Source.Name, t.Target.Name);

        [MethodImpl(Inline)]
        public static ArrowType<S,T> type<S,T>(S s = default, T t = default)
            => new ArrowType<S,T>(typeof(S),typeof(T));

        [MethodImpl(Inline), Op]
        public static ArrowType type(Type src, Type dst)
            => new ArrowType(src,dst);

        [MethodImpl(Inline)]
        public static string identify<S,T>(T src, S dst)
            => string.Format("{0} -> {1}", src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Arrow<T> link<T>(T src, T dst)
            => new Arrow<T>(src,dst);

        [MethodImpl(Inline)]
        public static Arrow<S,T> connect<S,T>(S src, T dst)
            => new Arrow<S,T>(src, dst);


        [MethodImpl(Inline)]
        public static Facet<N,A,S,T> facet<N,A,S,T>(N name, A value, S s = default, T t = default)
            => new Facet<N,A,S,T>(name,value);

        [MethodImpl(Inline), Op]
        public static Facet<S,T> facet<S,T>(in asci32 name, in variant value, Dependency<S,T> r = default)
            => new Facet<S,T>(name,value);

        [MethodImpl(Inline), Op]
        public static Facet<S,T> facet<A,S,T>(in asci32 name, A value, Dependency<S,T> r = default)
            where A : unmanaged
                => new Facet<S,T>(name, Variant.from(value));
    }
}