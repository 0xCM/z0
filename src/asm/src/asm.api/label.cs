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
        public static AsmLineLabel label(W8 w, ulong offset)
            => new AsmLineLabel((byte)offset);

        [MethodImpl(Inline), Op]
        public static AsmLineLabel label(W16 w, ulong offset)
            => new AsmLineLabel((ushort)offset);

        [MethodImpl(Inline), Op]
        public static AsmLineLabel label(W32 w, ulong offset)
            => new AsmLineLabel((uint)offset);

        [MethodImpl(Inline), Op]
        public static AsmLineLabel label(W64 w, ulong offset)
            => new AsmLineLabel(offset);
    }
}