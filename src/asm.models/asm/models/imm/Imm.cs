//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct Imm
    {
        [MethodImpl(Inline), Op]
        public Imm<W8,byte> imm8(byte value)
            => value;

        [MethodImpl(Inline), Op]
        public Imm<W16,byte> imm16(byte value)
            => value;

        [MethodImpl(Inline), Op]
        public Imm<W16,ushort> imm16(ushort value)
            => value;

        [MethodImpl(Inline), Op]
        public Imm<W32,byte> imm32(byte value)
            => value;

        [MethodImpl(Inline), Op]
        public Imm<W32,ushort> imm32(ushort value)
            => value;

        [MethodImpl(Inline), Op]
        public Imm<W32,uint> imm32(uint value)
            => value;

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