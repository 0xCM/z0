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

        [MethodImpl(Inline)]
        public string Format()
            => Index.ToString();

        public override string ToString()
            => Format();
    }
}