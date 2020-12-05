//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata.Ecma335;

    using static Part;

    public readonly struct CliArtifactKind : ICliRowKind<CliArtifactKind>
    {
        public TableIndex Index {get;}

        [MethodImpl(Inline)]
        public CliArtifactKind(TableIndex src)
            => Index = src;

        [MethodImpl(Inline)]
        public string Format()
            => Index.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TableIndex(CliArtifactKind src)
            => src.Index;

        [MethodImpl(Inline)]
        public static implicit operator CliArtifactKind(TableIndex src)
            => new CliArtifactKind(src);
    }
}