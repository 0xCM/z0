//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    unsafe partial class RegMachine
    {
        [MethodImpl(Inline), Op]
        public ref ulong reg64(RegIndex index)
            => ref @ref(R64 + (byte)index);

        [MethodImpl(Inline), Op]
        public ref uint reg32(RegIndex index)
            => ref u32(reg64(index));

        [MethodImpl(Inline), Op]
        public ref uint reg32b(RegIndex index)
            => ref @ref(R32 + 2*(byte)(index));

        [MethodImpl(Inline), Op]
        public ref ushort reg16(RegIndex index)
            => ref u16(reg64(index));

        [MethodImpl(Inline), Op]
        public ref ushort reg16b(RegIndex index)
            => ref @ref(R16 + 4*(byte)(index));

        [MethodImpl(Inline), Op]
        public ref byte reg8(RegIndex index)
            => ref u8(reg64(index));

        [MethodImpl(Inline), Op]
        public ref byte reg8b(RegIndex index)
            => ref @ref(R8 + 8*(byte)(index));

        [MethodImpl(Inline), Op]
        public ref Cell512 reg512(RegIndex index)
            => ref @ref(R512 + (byte)index);

        [MethodImpl(Inline), Op]
        public ref Cell256 reg256(RegIndex index)
            => ref @as<Cell512,Cell256>(reg512(index));

        [MethodImpl(Inline), Op]
        public ref Cell128 reg128(RegIndex index)
            => ref @as<Cell512,Cell128>(reg512(index));

        [MethodImpl(Inline), Op]
        public ref ulong mask(RegIndex index)
            => ref @ref(K + (byte)index);

        [MethodImpl(Inline), Op]
        public ref ulong rflags()
            => ref @ref(SYS);

        [MethodImpl(Inline), Op]
        public ref ulong rip()
            => ref @ref(SYS + 1);
    }
}