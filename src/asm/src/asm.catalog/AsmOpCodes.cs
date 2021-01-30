//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static OpCodeRegDigit digit(uint3 src)
            => new OpCodeRegDigit(src);

    }
}