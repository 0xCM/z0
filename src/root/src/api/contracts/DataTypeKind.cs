//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum TypeKind : ulong
    {
        None,

        UInt1 = 257,

        UInt2,

        UInt3,

        UInt4,

        UInt5,

        UInt6,

        UInt7,

        UInt8,

        Bit,

        Imm8,

        Imm8K,

        Imm16,

        Imm16K,
        Imm32,

        Imm32K,

        Imm64,

        Imm64K,

        ImmT
    }
}