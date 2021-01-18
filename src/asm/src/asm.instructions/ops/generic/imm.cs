//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmBuilder
    {
        [MethodImpl(Inline), Op]
        public Imm8Op imm8(byte pos, Imm8 value)
            => new Imm8Op(pos, value);

        [MethodImpl(Inline), Op]
        public Imm16Op imm16(byte pos, Imm16 value)
            => new Imm16Op(pos, value);

        [MethodImpl(Inline), Op]
        public Imm32Op imm32(byte pos, Imm32 value)
            => new Imm32Op(pos, value);

        [MethodImpl(Inline), Op]
        public Imm64Op imm64(byte pos, Imm64 value)
            => new Imm64Op(pos,value);
    }
}