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

    using L = Db.Literals;

    partial struct Db
    {
        public readonly struct ContentKinds
        {
            public static ContentKind Asm => L.asm;

            public static ContentKind Csv => L.csv;

            public static ContentKind Hex => L.hex;

            public static ContentKind MetadataBlob => L.metadata + dot + L.blob;

            public static ContentKind MetadataFields => L.metadata + dot + L.field;
        }
    }
}