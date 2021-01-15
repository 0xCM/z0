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
        public Imm<W64,byte> imm64(byte value)
            => value;

        [MethodImpl(Inline), Op]
        public Imm<W64,ushort> imm64(ushort value)
            => value;

        [MethodImpl(Inline), Op]
        public Imm<W64,uint> imm64(uint value)
            => value;

        [MethodImpl(Inline), Op]
        public Imm<W64,ulong> imm64(ulong value)
            => value;
    }
}