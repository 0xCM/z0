//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static Imm8 imm8(byte value)
            => new Imm8(value);

        [MethodImpl(Inline), Op]
        public static Imm16 imm16(ushort value)
            => new Imm16(value);

        [MethodImpl(Inline), Op]
        public static Imm32 imm32(uint value)
            => new Imm32(value);

        [MethodImpl(Inline), Op]
        public static Imm64 imm64(ulong value)
            => new Imm64(value);
    }
}