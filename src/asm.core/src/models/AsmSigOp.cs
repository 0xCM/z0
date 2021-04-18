//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents an operand in the context of an instruction signature
    /// </summary>
    public readonly struct AsmSigOp
    {
        public Identifier Name {get;}

        public SymExpr Symbol {get;}

        [MethodImpl(Inline)]
        public AsmSigOp(Identifier name, SymExpr symbol)
        {
            Name  = name;
            Symbol = symbol;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Name.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Name.IsNonEmpty;
        }

        public static AsmSigOp Empty
        {
            [MethodImpl(Inline)]
            get => new AsmSigOp(Identifier.Empty, SymExpr.Empty);
        }
    }
}