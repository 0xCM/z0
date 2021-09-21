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
        [MethodImpl(Inline), Op]
        public static AsmOperand generalize(RegOp src)
            => new AsmOperand(src);

        [MethodImpl(Inline), Op]
        public static AsmOperand generalize(imm8 src)
            => new AsmOperand(src);

        [MethodImpl(Inline), Op]
        public static AsmOperand generalize(imm16 src)
            => new AsmOperand(src);

        [MethodImpl(Inline), Op]
        public static AsmOperand generalize(imm32 src)
            => new AsmOperand(src);

        [MethodImpl(Inline), Op]
        public static AsmOperand generalize(imm64 src)
            => new AsmOperand(src);

        [MethodImpl(Inline), Op]
        public static AsmOperand generalize(m8 src)
            => new AsmOperand(src);

        [MethodImpl(Inline), Op]
        public static AsmOperand generalize(m16 src)
            => new AsmOperand(src);

        [MethodImpl(Inline), Op]
        public static AsmOperand generalize(m32 src)
            => new AsmOperand(src);

        [MethodImpl(Inline), Op]
        public static AsmOperand generalize(m64 src)
            => new AsmOperand(src);

        [MethodImpl(Inline), Op]
        public static AsmOperand generalize(m128 src)
            => new AsmOperand(src);

        [MethodImpl(Inline), Op]
        public static AsmOperand generalize(m256 src)
            => new AsmOperand(src);

        [MethodImpl(Inline), Op]
        public static AsmOperand generalize(m512 src)
            => new AsmOperand(src);
    }
}