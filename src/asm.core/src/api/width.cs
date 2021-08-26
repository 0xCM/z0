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
        public static BitWidth width(AsmSizeClass src)
            => Pow2.pow((byte)src)*8ul;

        [MethodImpl(Inline), Op]
        public static BitWidth width(AsmWidthCode src)
            => src != AsmWidthCode.W80 ? (Pow2.pow((byte)src)*8ul) : 80;
    }
}