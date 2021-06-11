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
        readonly Sym Symbol;

        [MethodImpl(Inline)]
        public AsmSigOp(Sym s)
        {
            Symbol = s;
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

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Symbol.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Symbol.IsNonEmpty;
        }

        public static AsmSigOp Empty
        {
            [MethodImpl(Inline)]
            get => new AsmSigOp(Sym.Empty);
        }
    }
}