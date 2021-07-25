//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [Flags]
    public enum AsmLinePart : ushort
    {
        None = 0,

        // iIdentifier:
        BlockLabel = 1,

        // 0005h
        OffsetLabel = 2,

        // mov rax,[rcx]
        Statement = 4,

        // ; ...
        Comment = 8,

        CodeSize = 16,

        // 48 8b 01
        HexCode = 32,

        // MOV r64, r/m64
        Sig = 64,

        // REX.W 8B /r
        OpCode = 128,

        // 0000 1010 ..
        BitCode = 256,

        // A label of some sort
        Label = 512,
    }
}