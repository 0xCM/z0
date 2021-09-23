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
    using static asm;

    partial class AsmSpecs
    {
        /// <summary>
        /// 3C ib
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("3C ib")]
        public static AsmInstruction cmp(al a, imm8 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// 3D iw
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("3D iw")]
        public static AsmInstruction cmp(ax a, imm16 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// 3D iw
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("3D iw")]
        public static AsmInstruction cmp(eax a, imm32 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// REX.W + 3D id
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("REX.W + 3D id")]
        public static AsmInstruction cmp(rax a, imm32 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// 80 /7 ib
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("80 /7 ib")]
        public static AsmInstruction cmp(r8b a, imm8 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// 80 /7 ib || REX + 80 /7 ib
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("80 /7 ib || REX + 80 /7 ib")]
        public static AsmInstruction cmp(m8 a, imm8 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// 81 /7 iw
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("81 /7 iw")]
        public static AsmInstruction cmp(r16 a, imm16 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// 81 /7 iw
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("81 /7 iw")]
        public static AsmInstruction cmp(m16 a, imm16 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// 81 /7 id
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("81 /7 id")]
        public static AsmInstruction cmp(r32 a, imm32 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// 81 /7 id
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("81 /7 id")]
        public static AsmInstruction cmp(m32 a, imm32 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// REX.W + 81 /7 id
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("REX.W + 81 /7 id")]
        public static AsmInstruction cmp(r64 a, imm32 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// REX.W + 81 /7 id
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("REX.W + 81 /7 id")]
        public static AsmInstruction cmp(m64 a, imm32 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// 83 /7 ib
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("83 /7 ib")]
        public static AsmInstruction cmp(r16 a, imm8 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// 83 /7 ib
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("83 /7 ib")]
        public static AsmInstruction cmp(m16 a, imm8 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// 83 /7 ib
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("83 /7 ib")]
        public static AsmInstruction cmp(r32 a, imm8 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// 83 /7 ib
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("")]
        public static AsmInstruction cmp(m32 a, imm8 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// REX.W + 83 /7 ib
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("REX.W + 83 /7 ib")]
        public static AsmInstruction cmp(r64 a, imm8 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// REX.W + 83 /7 ib
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("REX.W + 83 /7 ib")]
        public static AsmInstruction cmp(m64 a, imm8 imm)
            => fx(AsmId.AAA, op(a), op(imm));

        /// <summary>
        /// 38 /r || REX + 38 /r
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("38 /r || REX + 38 /r")]
        public static AsmInstruction cmp(r8 a, r8 b)
            => fx(AsmId.AAA, op(a), op(b));

        /// <summary>
        /// 38 /r || REX + 38 /r
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("38 /r || REX + 38 /r")]
        public static AsmInstruction cmp(m8 a, r8 b)
            => fx(AsmId.AAA, op(a), op(b));

        /// <summary>
        /// 39 /r
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("39 /r")]
        public static AsmInstruction cmp(r16 a, r16 b)
            => fx(AsmId.AAA, op(a), op(b));

        /// <summary>
        /// 39 /r
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("39 /r")]
        public static AsmInstruction cmp(m16 a, r16 b)
            => fx(AsmId.AAA, op(a), op(b));

        /// <summary>
        /// 39 /r
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("39 /r")]
        public static AsmInstruction cmp(r32 a, r32 b)
            => fx(AsmId.AAA, op(a), op(b));

        /// <summary>
        /// 39 /r
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("39 /r")]
        public static AsmInstruction cmp(m32 a, r32 b)
            => fx(AsmId.AAA, op(a), op(b));

        /// <summary>
        /// REX.W + 39 /r
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("REX.W + 39 /r")]
        public static AsmInstruction cmp(r64 a, r64 b)
            => fx(AsmId.AAA, op(a), op(b));

        /// <summary>
        /// REX.W + 39 /r
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("REX.W + 39 /r")]
        public static AsmInstruction cmp(m64 a, r64 b)
            => fx(AsmId.AAA, op(a), op(b));

        /// <summary>
        /// 3A /r || REX + 3A /r
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("3A /r || REX + 3A /r")]
        public static AsmInstruction cmp(r8 a, m8 b)
            => fx(AsmId.AAA, op(a), op(b));

        /// <summary>
        /// 3B /r
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("3B /r")]
        public static AsmInstruction cmp(r16 a, m16 b)
            => fx(AsmId.AAA, op(a), op(b));

        /// <summary>
        /// 3B /r
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("3B /r")]
        public static AsmInstruction cmp(r32 a, m32 b)
            => fx(AsmId.AAA, op(a), op(b));

        /// <summary>
        /// REX.W + 3B /r
        /// </summary>
        [MethodImpl(Inline), Op, OpCode("REX.W + 3B /r")]
        public static AsmInstruction cmp(r64 a, m64 b)
            => fx(AsmId.AAA, op(a), op(b));
    }
}