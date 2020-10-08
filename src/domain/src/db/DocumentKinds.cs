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
        public readonly struct DocumentKinds
        {
            public static DocumentKind Asm => L.asm;

            public static DocumentKind Cs => L.cs;

            public static DocumentKind Cil => L.il;

            public static DocumentKind Log => L.log;

            public static DocumentKind Hex => L.hex;

            public static DocumentKind Csv =>  L.csv;
        }
    }
}