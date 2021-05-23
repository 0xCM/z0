//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [Flags, SymbolSource]
    public enum AsmBitSize : byte
    {
        None = 0,

        [Symbol("b16")]
        Bits16 = 16,

        [Symbol("b32")]
        Bits32 = 32,

        [Symbol("b64")]
        Bits64 = 64,
    }
}