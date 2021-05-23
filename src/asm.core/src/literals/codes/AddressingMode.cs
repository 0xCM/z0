//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [Flags, SymbolSource]
    public enum AddressingMode : byte
    {
        None = 0,

        [Symbol("m16b")]
        Mode16 = 16,

        [Symbol("m32b")]
        Mode32 = 32,

        [Symbol("m64b")]
        Mode64 = 64,
    }
}