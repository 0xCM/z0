//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmOffsetLabel label(W16 w, ulong offset)
            => new AsmOffsetLabel((ushort)offset);

        [MethodImpl(Inline), Op]
        public static AsmLabel label(Identifier name)
            => new AsmLabel(name);
    }
}