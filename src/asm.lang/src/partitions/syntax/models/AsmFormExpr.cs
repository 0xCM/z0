//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmFormExpr : ITextual
    {
        public AsmOpCodeExpr OpCode {get;}

        public AsmSigExpr Sig {get;}

        [MethodImpl(Inline)]
        internal AsmFormExpr(AsmOpCodeExpr opcode, AsmSigExpr sig)
        {
            OpCode = opcode;
            Sig = sig;
        }

        public Index<AsmSigOperandExpr> Operands
        {
            [MethodImpl(Inline)]
            get => Sig.Operands;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => OpCode.IsEmpty || Sig.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsmFormExpr src)
            => OpCode == src.OpCode && Sig == src.Sig;

        public override bool Equals(object src)
            => src is AsmFormExpr x && Equals(x);

        public override int GetHashCode()
            => (int)alg.hash.combine(OpCode.GetHashCode(), Sig.GetHashCode());

        public string Format()
            => AsmSyntax.format(this);

        public override string ToString()
            => Format();

        public static AsmFormExpr Empty
            => new AsmFormExpr(AsmOpCodeExpr.Empty, AsmSigExpr.Empty);
    }
}