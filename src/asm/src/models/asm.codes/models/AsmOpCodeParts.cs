//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an asm opcode and carries the source exrpression along for the ride
    /// </summary>
    public readonly struct AsmOpCodeParts
    {
        public readonly AsmOpCodeExpression Expression;

        public readonly TableSpan<AsmOpCodePart> Parts;

        [MethodImpl(Inline)]
        public AsmOpCodeParts(AsmOpCodeExpression expression, params AsmOpCodePart[] parts)
        {
            Expression = expression;
            Parts = parts;
        }
    }
}