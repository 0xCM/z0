//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmInstructions;
    using static Hex8Seq;
    using static AsmOps;
    using static AsmHexCodes;

    partial struct AsmEncoder
    {
        /// <summary>
        /// | FF /4       | JMP r/m64    | M     | Valid
        /// </summary>
        /// <param name="dst"></param>
        [MethodImpl(Inline), Op]
        public static Jmp jmp(r64 dst)
            => asmhex(RexW, xff, rd4);
    }


    /*

    ; byte effsize<long>(long src)::located://bitcore/gbits?effsize#effsize_g[64i](64i)
    ; public static ReadOnlySpan<byte> effsize_gᐸ64iᐳᐤ64iᐤ => new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0xb8,0x80,0xb7,0x67,0x7a,0xfa,0x7f,0x00,0x00,0x48,0xff,0xe0};
    ; BaseAddress = 7ffa7a67c670h
    ; TermCode = CTC_JMP_RAX
    0000h nop dword ptr [rax+rax]                       ; NOP r/m32                        | 0F 1F /0                         | 5   | 0f 1f 44 00 00
    0005h mov rax,7ffa7a67b780h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b8 80 b7 67 7a fa 7f 00 00
    000fh jmp rax                                       ; JMP r/m64                        | FF /4                            | 3   | 48 ff e0

    */
}