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

    public readonly struct ArtifactKey
    {
        public readonly Key<ArtifactKind,ArtifactIdentifier> Value;

        public ArtifactIdentifier Id => Value.Identifier;

        public ArtifactKind Kind => Value.Kind;

        [MethodImpl(Inline)]
        public static implicit operator ArtifactKey(Paired<ArtifactKind,ArtifactIdentifier> src)
            => new ArtifactKey(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator Paired<ArtifactKind,ArtifactIdentifier>(ArtifactKey src)
            => paired(src.Kind, src.Id);

        [MethodImpl(Inline)]
        public ArtifactKey(ArtifactKind kind, ArtifactIdentifier id)
        {
            Value = (kind,id);
        }
    }
}