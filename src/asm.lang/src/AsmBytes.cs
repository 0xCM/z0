//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct AsmBytes
    {
        [MethodImpl(Inline), Op]
        public static bit IsRexPrefix(AsmByte src)
            => (src & 0x40) != 0;
    }
}