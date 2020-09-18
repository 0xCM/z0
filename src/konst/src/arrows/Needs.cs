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

        [MethodImpl(Inline), Op]
        public static ArtifactRef reference(Type src)
            => new ArtifactRef(src);

        [MethodImpl(Inline), Op]
        public static ArtifactRef reference(ArtifactIdentifier src)
            => new ArtifactRef(src);

        [MethodImpl(Inline)]
        public static Facet<N,A,S,T> facet<N,A,S,T>(N name, A value, S s = default, T t = default)
            => new Facet<N,A,S,T>(name,value);

        [MethodImpl(Inline), Op]
        public static Facet<S,T> facet<S,T>(in asci32 name, in variant value, Need<S,T> r = default)
            => new Facet<S,T>(name,value);

        [MethodImpl(Inline), Op]
        public static Facet<S,T> facet<A,S,T>(in asci32 name, A value, Need<S,T> r = default)
            where A : unmanaged
                => new Facet<S,T>(name, Variant.from(value));

        [MethodImpl(Inline), Op]
        public static ArrowFacet<ArtifactIdentifier> facet(ArtifactIdentifier src, ArtifactIdentifier dst, in asci32 name, in variant value)
            => new ArrowFacet<ArtifactIdentifier>((src,dst), name, value);

        [MethodImpl(Inline), Op]
        public static ArrowFacet<ArtifactIdentifier> facet(ArtifactIdentifier src, ArtifactIdentifier dst, string name, in variant value)
            => new ArrowFacet<ArtifactIdentifier>((src,dst), name, value);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ArrowFacet<ArtifactIdentifier> facet<A>(ArtifactIdentifier src, ArtifactIdentifier dst, string name, A value)
            where A : unmanaged
                => new ArrowFacet<ArtifactIdentifier>((src,dst), name, Variant.from(value));
    }
}