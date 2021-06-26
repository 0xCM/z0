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
    using static AsmOpTypes;
    using static AsmCodes;
    using static Hex8Seq;

    partial struct asm
    {
        // REX.W + B8+ rd io | MOV r64, imm64           | OI    | Valid       | N.E.            | Move imm64 to r64.                                             |
        [MethodImpl(Inline), Op]
        public static Mov mov(r64 r64, Imm64 imm64)
            => AsmEncoder.encode(RexW, (Hex8)(0xb8 + (byte)r64.Index), imm64);

        /// <summary>
        /// (AND AL, imm8)[24 ib]
        /// </summary>
        /// <param name="r"></param>
        /// <param name="imm8"></param>
        public static And and(al r, Imm8 imm8)
            => AsmEncoder.encode(x24, imm8);

        /// <summary>
        /// (AND r/m8, imm8)[80 /4 ib]
        /// </summary>
        /// <param name="r"></param>
        /// <param name="imm8"></param>
        [MethodImpl(Inline), Op]
        public static And and(r8b r, Imm8 imm8)
            => AsmEncoder.encode(x24, imm8);

        // /// <summary>
        // /// (JA rel8) 77 cb
        // /// </summary>
        // /// <param name="cb"></param>
        // [MethodImpl(Inline), Op]
        // public static Ja ja(Address8 cb)
        //     => AsmBytes.code(x77, cb);

        // /// <summary>
        // /// (JA rel32) 0F 87 cd
        // /// </summary>
        // /// <param name="cb"></param>
        // [MethodImpl(Inline), Op]
        // public static Ja ja(Address32 cd)
        //     => AsmBytes.code(x77, cd);

        /// <summary>
        /// | 0F B6 /r | MOVZX r16, r8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static Movzx movzx(r16 dst, r8 src)
            => default;

        /// <summary>
        /// | 0F B6 /r | MOVZX r16, m8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The memory source</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static Movzx movzx(r16 dst, mem<r8> src)
            => default;

        /// <summary>
        /// 0F B6 /r | MOVZX r32, r8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static Movzx movzx(r32 dst, r8 src)
            => default;

        /// <summary>
        /// 0F B6 /r | MOVZX r32, m8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static Movzx movzx(r32 dst, mem<r8> src)
            => default;

        /// <summary>
        /// REX.W + 0F B6 /r | MOVZX r64, r8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static Movzx movzx(r64 dst, r8 src)
            => default;

        /// <summary>
        /// REX.W + 0F B6 /r | MOVZX r64, m8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static Movzx movzx(r64 dst, mem<r8> src)
            => default;

        /// <summary>
        /// 0F B7 /r | MOVZX r32, r16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static Movzx movzx(r32 dst, r16 src)
            => default;

        /// <summary>
        /// 0F B7 /r | MOVZX r32, m16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static Movzx movzx(r32 dst, mem<r16> src)
            => default;

        /// <summary>
        /// REX.W + 0F B7 /r | MOVZX r64, m16 | Move word to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static Movzx movzx(r64 dst, mem<r16> src)
            => default;
    }
}