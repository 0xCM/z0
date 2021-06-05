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

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmOpCodeExpr opcode(string src)
            => new AsmOpCodeExpr(src);
    }
}