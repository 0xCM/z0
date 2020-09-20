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
    using static ArtifactModel;

    [ApiHost]
    public readonly partial struct Needs
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static TypeRef<T> reference<T>(T t = default)
            => default;


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