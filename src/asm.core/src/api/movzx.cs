//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOperands;

    partial struct asm
    {
        /// <summary>
        /// | 0F B6 /r | MOVZX r16, r8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmHexCode movzx(r16 dst, r8 src)
        {
            const string OpCode = "0F B6 /r";
            var encoding = AsmHexCode.Empty;
            encoding.Cell(0) = modrm(0,dst.Index, src.Index);
            encoding.Cell(1) = 0xB6;
            encoding.Cell(2) = 0x0F;
            encoding.Cell(3) = 0x66;
            encoding.Cell(15) = 5;
            return encoding;
        }

        /// <summary>
        /// | 0F B6 /r | MOVZX r16, m8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The memory source</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static AsmHexCode movzx(r16 dst, mem<r8> src)
            => default;

        /// <summary>
        /// 0F B6 /r | MOVZX r32, r8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmHexCode movzx(r32 dst, r8 src)
            => default;

        /// <summary>
        /// 0F B6 /r | MOVZX r32, m8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static AsmHexCode movzx(r32 dst, mem<r8> src)
            => default;

        /// <summary>
        /// REX.W + 0F B6 /r | MOVZX r64, r8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmHexCode movzx(r64 dst, r8 src)
            => default;

        /// <summary>
        /// REX.W + 0F B6 /r | MOVZX r64, m8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static AsmHexCode movzx(r64 dst, mem<r8> src)
            => default;

        /// <summary>
        /// 0F B7 /r | MOVZX r32, r16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmHexCode movzx(r32 dst, r16 src)
            => default;

        /// <summary>
        /// 0F B7 /r | MOVZX r32, m16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmHexCode movzx(r32 dst, mem<r16> src)
            => default;

        /// <summary>
        /// REX.W + 0F B7 /r | MOVZX r64, m16 | Move word to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmHexCode movzx(r64 dst, mem<r16> src)
            => default;
    }
}