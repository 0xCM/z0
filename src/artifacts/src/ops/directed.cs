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
        public static DirectedRelation<S,T> directed<S,T>(S src = default, T dst = default)
            => default;

        [MethodImpl(Inline)]
        public static DirectedRelation<S,T> directed<S,T>(TypeRef<S> src, TypeRef<T> dst)
            => default;

        [MethodImpl(Inline), Op]
        public static DirectedRelation directed(Type src, Type dst)
            => new DirectedRelation(src,dst);

        [MethodImpl(Inline), Op]
        public static DirectedRelation directed(ArtifactIdentifier src, ArtifactIdentifier dst)
            => new DirectedRelation(src,dst);
    }
}