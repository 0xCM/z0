//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public enum AsmDocPartKind : ulong
    {
        None = 0,

        // 0005h
        LineLabel,

        // mov rax,[rcx]
        Statement,

        UriSig,

        // MOV r64, r/m64
        AsmSig,

        // REX.W 8B /r
        OpCode,

        // 48 8b 01
        StatementEncoding,

        // ; ...
        Comment,

        BlockHeader,

        BlockHeaderLine,

        EncodingSize,

        // {0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x85,0xc0,0x75,0x04,0x33,0xd2,0xeb,0x03,0x8b,0x50,0x08,0x85,0xd2,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xc3}
        BlockEncoding
    }
}