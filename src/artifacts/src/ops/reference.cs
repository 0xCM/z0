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
        public static TypeRef<T> reference<T>(T t = default)
            => default;

        [MethodImpl(Inline), Op]
        public static ArtifactRef reference(Type src)
            => new ArtifactRef(src);

        [MethodImpl(Inline), Op]
        public static ArtifactRef reference(ArtifactIdentifier src)
            => new ArtifactRef(src);
    }
}