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
        [Op]
        public static AsmBitstring bitstring(AsmHexCode src)
            => AsmBitstrings.bitstring(src);
    }
}