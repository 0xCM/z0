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

    public readonly struct ContentKinds
    {
        public static AsmDoc Asm => default;

        public static CsvDoc Csv => default;

        public static HexDoc Hex => default;
    }
}