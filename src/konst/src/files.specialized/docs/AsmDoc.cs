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

    public readonly struct AsmDoc : IKindedContent<AsmDoc,ContentKind,CharCells>
    {
        public const string Name = ArchiveFileKindNames.asm;

        public CharCells Content {get;}

        [MethodImpl(Inline)]
        public AsmDoc(char[] src)
            => Content = src;

        public ContentKind Kind
            => ContentKind.Asm;

        public string KindId
            => Name;

        public FK.Asm FileKind
            => K.Asm;

        public string Format()
            => Name;

        public override string ToString()
            => Format();
    }
}