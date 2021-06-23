//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Represents an operand in the context of an instruction signature
    /// </summary>
    public readonly struct AsmSigOp
    {
        readonly byte Data;

        [MethodImpl(Inline)]
        internal AsmSigOp(byte data)
        {
            Data = data;
        }

        public SymExpr Expr
        {
            [MethodImpl(Inline)]
            get => SymExpr.Empty;
        }
    }
}