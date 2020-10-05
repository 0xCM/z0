//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata.Ecma335;

    using static Konst;
    using static z;

    public readonly struct ArtifactKey<K>
        where K : unmanaged, IArtifactKind<K>
    {
        public readonly ClrArtifactKey Id;

        [MethodImpl(Inline)]
        public static implicit operator ArtifactKey<K>(ClrArtifactKey id)
            => new ArtifactKey<K>(id);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactKey(ArtifactKey<K> src)
            => new ArtifactKey(src.Kind.Index, src.Id);

        [MethodImpl(Inline)]
        public ArtifactKey(ClrArtifactKey id)
            => Id = id;

        public TableIndex Index => Kind.Index;

        public K Kind => default(K);
    }
}