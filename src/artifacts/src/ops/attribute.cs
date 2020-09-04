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

    partial struct Needs
    {
        [MethodImpl(Inline)]
        public static NeedAttribute<N,A,S,T> attribute<N,A,S,T>(N name, A value, S s = default, T t = default)
            => new NeedAttribute<N,A,S,T>(name,value);

        // [MethodImpl(Inline), Op]
        // public static NeedAttribute attribute(ArtifactRelation r, in asci32 name, in variant value)
        //     => new NeedAttribute(r,name,value);

        // [MethodImpl(Inline), Op]
        // public static NeedAttribute attribute<A>(ArtifactRelation r, in asci32 name, A value)
        //     where A : unmanaged
        //         => new NeedAttribute(r,name,Variant.from(value));

        [MethodImpl(Inline), Op]
        public static NeedAttribute<S,T> attribute<S,T>(in asci32 name, in variant value, Need<S,T> r = default)
            => new NeedAttribute<S,T>(name,value);

        [MethodImpl(Inline), Op]
        public static NeedAttribute<S,T> attribute<A,S,T>(in asci32 name, A value, Need<S,T> r = default)
            where A : unmanaged
                => new NeedAttribute<S,T>(name, Variant.from(value));

        [MethodImpl(Inline), Op]
        public static NeedAttribute<ArtifactIdentifier> attribute(ArtifactIdentifier src, ArtifactIdentifier dst, in asci32 name, in variant value)
            => new NeedAttribute<ArtifactIdentifier>((src,dst), name, value);

        [MethodImpl(Inline), Op]
        public static NeedAttribute<ArtifactIdentifier> attribute(ArtifactIdentifier src, ArtifactIdentifier dst, string name, in variant value)
            => new NeedAttribute<ArtifactIdentifier>((src,dst), name, value);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static NeedAttribute<ArtifactIdentifier> attribute<A>(ArtifactIdentifier src, ArtifactIdentifier dst, string name, A value)
            where A : unmanaged
                => new NeedAttribute<ArtifactIdentifier>((src,dst), name, Variant.from(value));
    }
}