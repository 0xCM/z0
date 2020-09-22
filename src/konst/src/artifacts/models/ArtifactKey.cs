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

    public readonly struct ArtifactKey
    {
        public readonly Key<ArtifactKind,ApiArtifactKey> Value;

        public ApiArtifactKey Id => Value.Identifier;

        public ArtifactKind Kind => Value.Kind;

        [MethodImpl(Inline)]
        public static implicit operator ArtifactKey(Paired<ArtifactKind,ApiArtifactKey> src)
            => new ArtifactKey(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator Paired<ArtifactKind,ApiArtifactKey>(ArtifactKey src)
            => paired(src.Kind, src.Id);

        [MethodImpl(Inline)]
        public ArtifactKey(ArtifactKind kind, ApiArtifactKey id)
        {
            Value = (kind,id);
        }
    }
}