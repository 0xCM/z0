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
        public static AsmOffsetLabel label(byte width, ulong value)
            => new AsmOffsetLabel(width, value);

        [MethodImpl(Inline), Op]
        public static AsmLabel label(in CharBlock32 name, Hex64 offset = default)
            => new AsmLabel(name, offset);
    }
}