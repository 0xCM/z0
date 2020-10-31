//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    using K = FileKindType;
    using FK = FileKindTypes;

    public readonly struct HexDoc : IKindedContent<HexDoc,ContentKind,CharCells>
    {
        public const string Name = ArchiveFileKindNames.hex;

        public CharCells Content {get;}

        [MethodImpl(Inline)]
        public HexDoc(CharCells src)
            => Content = src;

        public ContentKind Kind
            => ContentKind.Asm;

        public string KindId
            => Name;

        public FK.Hex FileKind
            => K.Hex;
        public string Format()
            => Name;

        public override string ToString()
            => Format();
    }
}