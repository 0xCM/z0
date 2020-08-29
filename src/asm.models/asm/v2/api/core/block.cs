//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmFxBlock block(X86ApiCode encoded, Instruction[] decoded, ExtractTermCode term)
            => new AsmFxBlock(encoded, decoded, term);
    }
}