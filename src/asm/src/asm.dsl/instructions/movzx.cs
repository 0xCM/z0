//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmDsl;
    using M = AsmMnemonics;

    using static asm;

    partial struct AsmBuilder
    {
        /// <summary>
        /// MOVZX r16, r/m8 - Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op, AsmSpec("0F B6 / r","MOVZX r16, r8", "Move byte to word with zero-extension.")]
        public AsmStatement<r16,r8> movzx(r16 dst, r8 src)
            => asm.statement(M.movzx, args(dst,src));

        /// <summary>
        /// MOVZX r16, m8 - Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op, AsmSpec("0F B6 / r","MOVZX r16, m8", "Move byte to word with zero-extension.")]
        public AsmStatement<r16,m8> movzx(r16 dst, m8 src)
            => asm.statement(M.movzx, args(dst,src));

        /// <summary>
        /// 0F B6 / r         | MOVZX r32, r8  | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op, AsmSpec("0F B6 / r","MOVZX r32, r8", "Move byte to doubleword, zero-extension")]
        public AsmStatement<r32,r8> movzx(r32 dst, r8 src)
            => asm.statement(M.movzx, args(dst,src));

        /// <summary>
        /// 0F B6 / r         | MOVZX r32, m8  | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op, AsmSpec("0F B6 / r","MOVZX r32, m8")]
        public AsmStatement<r32,m8> movzx(r32 dst, m8 src)
            => asm.statement(M.movzx, args(dst,src));

        /// <summary>
        /// REX.W + 0F B6 / r | MOVZX r64, r/m8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op, AsmSpec("REX.W + 0F B6 / r","MOVZX r64, r8")]
        public AsmStatement<r64,r8> movzx(r64 dst, r8 src)
            => asm.statement(M.movzx, args(dst,src));

        /// <summary>
        /// REX.W + 0F B6 / r | MOVZX r64, r/m8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op, AsmSpec("REX.W + 0F B6 / r","MOVZX r64, m8")]
        public AsmStatement<r64,m8> movzx(r64 dst, m8 src)
            => asm.statement(M.movzx, args(dst,src));

        /// <summary>
        /// 0F B7 / r         | MOVZX r32, r/m16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op, AsmSpec("0F B7 / r","MOVZX r32, r16")]
        public AsmStatement<r32,r16> movzx(r32 dst, r16 src)
            => asm.statement(M.movzx, args(dst,src));

        /// <summary>
        /// 0F B7 / r         | MOVZX r32, r/m16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op, AsmSpec("0F B7 / r","MOVZX r32, m16")]
        public AsmStatement<r32,m16> movzx(r32 dst, m16 src)
            => asm.statement(M.movzx, args(dst,src));

        /// <summary>
        /// REX.W + 0F B7 / r | MOVZX r64, r/m16 |  Move word to quadword, zero-extension.
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op, AsmSpec("REX.W + 0F B7 / r","MOVZX r64, r16")]
        public AsmStatement<r64,r16> movzx(r64 dst, r16 src)
            => asm.statement(M.movzx, args(dst,src));

        /// <summary>
        /// REX.W + 0F B7 / r | MOVZX r64, r/m16 |  Move word to quadword, zero-extension.
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op, AsmSpec("REX.W + 0F B7 / r","MOVZX r64, m16")]
        public AsmStatement<r64,m16> movzx(r64 dst, m16 src)
            => asm.statement(M.movzx, args(dst,src));
    }
}