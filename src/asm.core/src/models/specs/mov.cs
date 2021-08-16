//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmInstructions;
    using static AsmOperands;
    using static AsmPrefixCodes;

    partial class AsmSpecs
    {
        /// <summary>
        ///  MOV r/m16, imm16 | C7 /0 iw
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        /// <param name="hex"></param>
        public static byte mov(in AsmAddress dst, Imm16 src, ref byte hex)
        {
            // mov word ptr [r11+r10*2],20h | 66 43 c7 04 53 20 00
            // mov word ptr [rcx+0ah],20h   | 66 c7 41 0a 20 00
            return 0;
        }

        /// <summary>
        /// MOV r/m8, r8 | 88 /r
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        /// <param name="hex"></param>
        public static byte mov(in AsmAddress dst, r8b src, ref byte hex)
        {
            // mov [rcx+8],sil | 40 88 71 08 | 0100 0000 1000 1000 0111 0001 0000 1000
            return 0;
        }

        // REX.W + B8+ rd io | MOV r64, imm64           | OI    | Valid       | N.E.            | Move imm64 to r64.                                             |
        [MethodImpl(Inline), Op]
        public static Mov mov(r64 r64, Imm64 imm64)
            => AsmEncoder.encode(RexW, (Hex8)(0xb8 + (byte)r64.Index), imm64);
    }
}