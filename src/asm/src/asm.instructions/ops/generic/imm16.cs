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
        public Imm<W16,byte> imm16(byte value)
            => value;

        [MethodImpl(Inline), Op]
        public Imm<W16,ushort> imm16(ushort value)
            => value;
    }
}