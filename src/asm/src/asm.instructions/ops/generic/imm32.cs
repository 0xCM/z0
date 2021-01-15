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
        public Imm<W32,byte> imm32(byte value)
            => value;

        [MethodImpl(Inline), Op]
        public Imm<W32,ushort> imm32(ushort value)
            => value;

        [MethodImpl(Inline), Op]
        public Imm<W32,uint> imm32(uint value)
            => value;
    }
}