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

    partial struct ArtifactRelations
    {
        [MethodImpl(Inline)]
        public static RelationAttribute<N,A,S,T> attribute<N,A,S,T>(N name, A value, S s = default, T t = default)
            => new RelationAttribute<N,A,S,T>(name,value);

        [MethodImpl(Inline), Op]
        public static RelationAttribute attribute(DirectedRelation r, in asci32 name, in variant value)
            => new RelationAttribute(r,name,value);

        [MethodImpl(Inline), Op]
        public static RelationAttribute attribute<A>(DirectedRelation r, in asci32 name, A value)
            where A : unmanaged
                => new RelationAttribute(r,name,Variant.from(value));

        [MethodImpl(Inline), Op]
        public static RelationAttribute<S,T> attribute<S,T>(in asci32 name, in variant value, DirectedRelation<S,T> r = default)
            => new RelationAttribute<S,T>(name,value);

        [MethodImpl(Inline), Op]
        public static RelationAttribute<S,T> attribute<A,S,T>(in asci32 name, A value, DirectedRelation<S,T> r = default)
            where A : unmanaged
                => new RelationAttribute<S,T>(name, Variant.from(value));

        [MethodImpl(Inline), Op]
        public static RelationAttribute attribute(ArtifactIdentifier src, ArtifactIdentifier dst, in asci32 name, in variant value)
            => new RelationAttribute(directed(src,dst), name, value);

        [MethodImpl(Inline), Op]
        public static RelationAttribute attribute(ArtifactIdentifier src, ArtifactIdentifier dst, string name, in variant value)
            => new RelationAttribute(directed(src,dst), name, value);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static RelationAttribute attribute<A>(ArtifactIdentifier src, ArtifactIdentifier dst, string name, A value)
            where A : unmanaged
                => new RelationAttribute(directed(src,dst), name, Variant.from(value));
    }
}