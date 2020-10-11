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

    using K = FileKind;
    using FK = FileKinds;

    public readonly struct CsvDoc : IContentKind<CsvDoc,ContentKind,string>
    {
        public const string Name = "csv";

        public ContentKind Kind
            => ContentKind.Asm;

        public string Id
            => Name;

        public FK.Csv FileKind
            => K.Csv;

        public string Format()
            => Name;

        public override string ToString()
            => Format();
    }
}