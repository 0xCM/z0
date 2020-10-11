//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = FileKinds;

    public readonly struct FileKind
    {
        public static K.Csv Csv => default;

        public static K.Asm Asm => default;

        public static K.Dll Dll => default;

        public static K.Cil Cil => default;

        public static K.Hex Hex => default;
    }
}