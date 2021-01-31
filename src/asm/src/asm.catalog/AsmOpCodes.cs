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

    using static AsmOpCodeModel;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static RegDigit digit(uint3 src)
            => new RegDigit(src);


        public static string normalize(AsmSigExpr sig, string opcode)
            => opcode;
    }
}