//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        public static AsmOpCodeExpr conform(string src)
            => AsmCore.opcode(src.Replace("o32 ", EmptyString).Replace("o16 ", EmptyString).Replace("+", " +"));
    }
}