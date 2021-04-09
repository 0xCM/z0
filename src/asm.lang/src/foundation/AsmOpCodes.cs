//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        public static AsmOpCodeExpr conform(string src)
            => asm.opcode(src.Replace("o32 ", EmptyString).Replace("o16 ", EmptyString).Replace("+", " +"));

        public static AsmHexCode create()
            => new AsmHexCode();
    }
}