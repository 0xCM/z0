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

    public readonly struct ArtifactKind<K> : IArtifactKind<K>
        where K : unmanaged, IArtifactKind<K>
    {
        [MethodImpl(Inline)]
        public static implicit operator ArtifactKind<K>(K src)
            => default;

        public TableIndex Index => default(K).Index;
    }

    public readonly struct ArtifactKind : IArtifactKind<ArtifactKind>
    {
        public TableIndex Index {get;}

        [MethodImpl(Inline)]
        public static implicit operator TableIndex(ArtifactKind src)
            => src.Index;

        [MethodImpl(Inline)]
        public static implicit operator ArtifactKind(TableIndex src)
            => new ArtifactKind(src);

        [MethodImpl(Inline)]
        public ArtifactKind(TableIndex src)
        {
            Index = src;
        }
    }
}