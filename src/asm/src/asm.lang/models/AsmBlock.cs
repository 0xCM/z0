//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct AsmBlock
    {
        // 7ffc5e1eff50h
        public MemoryAddress BaseAddress;

        // Byte[] alloc<byte>(long count)::located://part/sys.proxy?alloc#alloc_g[8u](64i)
        public TextBlock SigUri;

        // {0x48,0x83,0xec,0x28,0x90,0x48,0x8b,0xd1,0x48,0xb9,0x18,0xea,0x10,0x5b,0xfc,0x7f,0x00,0x00,0xe8,0x19,0x79,0xa6,0x5c,0x90,0x48,0x83,0xc4,0x28,0xc3}
        public BinaryCode Encoded;

        // 0000h sub rsp,28h                             ; SUB r/m64, imm8                  | REX.W 83 /5 ib                   | 4   | 48 83 ec 28
        // 0004h nop                                     ; NOP                              | 90                               | 1   | 90
        // 0005h mov rdx,rcx                             ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b d1
        // 0008h mov rcx,7ffc5b10ea18h                   ; MOV r64, imm64                   | REX.W B8+ro io                   | 10  | 48 b9 18 ea 10 5b fc 7f 00 00
        // 0012h call 7ffcbac57880h                      ; CALL rel32                       | E8 cd                            | 5   | e8 19 79 a6 5c
        // 0017h nop                                     ; NOP                              | 90                               | 1   | 90
        // 0018h add rsp,28h                             ; ADD r/m64, imm8                  | REX.W 83 /0 ib                   | 4   | 48 83 c4 28
        // 001ch ret                                     ; RET                              | C3                               | 1   | c3
        public TextBlock AsmText;
    }
}