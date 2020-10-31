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

    public readonly struct CsvDoc : IKindedContent<CsvDoc,ContentKind,CharCells>
    {
        public const string Name = ArchiveFileKindNames.csv;

        public CharCells Content {get;}

        public ContentKind Kind
            => ContentKind.Asm;

        public string KindId
            => Name;

        public FK.Csv FileKind
            => K.Csv;

        public string Format()
            => Name;

        public override string ToString()
            => Format();
    }
}