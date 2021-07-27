//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [SymSource]
    public enum AddressingKind : byte
    {
        None = 0,

        [Symbol("m16b", "Specifies 16-bit addressing")]
        Mode16=1,

        [Symbol("m32b", "Specifies 32-bit addressing")]
        Mode32=2,

        [Symbol("m64b", "Specifies 64-bit addressing")]
        Mode64=3,
    }

    [Flags, SymSource]
    public enum OperandSize : byte
    {
        [Symbol("w16")]
        W16 = (byte)DataWidth.W16,

        [Symbol("w32")]
        W32 = (byte)DataWidth.W32,

        [Symbol("w64")]
        W64 = (byte)DataWidth.W64
    }
}