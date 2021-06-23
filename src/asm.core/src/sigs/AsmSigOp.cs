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
        readonly ISym Symbol;

        [MethodImpl(Inline)]
        internal AsmSigOp(ISym s)
        {
            Symbol = s;
        }

        public SymIdentity Identity
        {
            [MethodImpl(Inline)]
            get => Symbol.Identity;
        }

        public Identifier Name
        {
            [MethodImpl(Inline)]
            get => Symbol.Name;
        }

        public SymExpr Expr
        {
            [MethodImpl(Inline)]
            get => Symbol.Expr;
        }
    }
}