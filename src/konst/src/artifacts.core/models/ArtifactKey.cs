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

    public readonly struct ArtifactKey : ITextual
    {
        public readonly Key<ArtifactKind,ClrArtifactKey> Value;

        public ClrArtifactKey Id => Value.Identifier;

        public ArtifactKind Kind => Value.Kind;

        [MethodImpl(Inline)]
        public static implicit operator ArtifactKey(Paired<ArtifactKind,ClrArtifactKey> src)
            => new ArtifactKey(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator Paired<ArtifactKind,ClrArtifactKey>(ArtifactKey src)
            => paired(src.Kind, src.Id);

        [MethodImpl(Inline)]
        public ArtifactKey(ArtifactKind kind, ClrArtifactKey id)
        {
            Value = (kind,id);
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("{0}:{1}", Kind, Id);
    }
}