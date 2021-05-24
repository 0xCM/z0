//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    using static Pow2x32;

    [Flags]
    public enum NasmPathKind : uint
    {
        None = 0,

        AsmSource = P2ᐞ00,

        BinTarget = P2ᐞ01,
    }
}