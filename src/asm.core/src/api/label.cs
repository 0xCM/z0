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
        public static AsmOffsetLabel label(DataWidth w, ulong offset)
            => new AsmOffsetLabel(w, offset);

        [MethodImpl(Inline), Op]
        public static AsmLabel label(Identifier name)
            => new AsmLabel(name);

        [MethodImpl(Inline), Op]
        public static AsmBlockLabel label(MemoryAddress address)
            => new AsmBlockLabel(string.Format("_{0}", address));
    }
}