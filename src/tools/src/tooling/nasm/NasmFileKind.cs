//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public enum NasmFileKind : byte
    {
        None = 0,

        Asm = 1,

        Obj = 2,

        Bin = 4,

        AsmList = 8,
    }

}