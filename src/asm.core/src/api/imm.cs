//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOperandTypes;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static imm8 imm8(byte value)
            => new imm8(value);

        [MethodImpl(Inline), Op]
        public static imm16 imm16(ushort value)
            => new imm16(value);

        [MethodImpl(Inline), Op]
        public static imm32 imm32(uint value)
            => new imm32(value);

        [MethodImpl(Inline), Op]
        public static imm64 imm64(ulong value)
            => new imm64(value);
    }
}