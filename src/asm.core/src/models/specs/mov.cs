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
            // REX + C6 / 0 ib   | MOV r/m8,imm8
            // B8+ rd id         | MOV r32,imm32
            // REX + B0+ rb ib   | MOV r8,imm8
            // B8+ rw iw         | MOV r16,imm16
            // C7 / 0 iw         | MOV r/m16,imm16
            // C7 / 0 id         | MOV r/m32,imm32
            // REX.W + B8+ rd io | MOV r64,imm64

        public static byte mov(in r8b dst, imm8 src, ref byte hex)
        {
            // imm8 -> r8b
            var i8 = llvm.AsmId.MOV8ri;
            // imm8 -> m8
            var i7 = llvm.AsmId.MOV8mi;

            // imm16 -> r16
            var i1 = llvm.AsmId.MOV16ri;
            // imm16 -> m16
            var i0 = llvm.AsmId.MOV16mi;

            // imm32 -> r32
            var i3 = llvm.AsmId.MOV32ri;
            // imm32 -> m32
            var i2 = llvm.AsmId.MOV32mi;

            // imm64 -> r64
            var i5 = llvm.AsmId.MOV64ri;

            // imm32 -> r64
            var i6 = llvm.AsmId.MOV64ri32;
            // imm32 -> m64
            var i4 = llvm.AsmId.MOV64mi32;
            return 0;
        }

        public static byte mov(in m8 dst, imm8 src, ref byte hex)
        {

            return 0;
        }

        /// <summary>
        ///  MOV r/m16, imm16 | C7 /0 iw
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        /// <param name="hex"></param>
        public static byte mov(in AsmAddress dst, imm16 src, ref byte hex)
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
        public static Mov mov(r64 r64, imm64 imm64)
            => AsmEncoding.encode(RexW, (Hex8)(0xb8 + (byte)r64.Index), imm64);
    }
}