//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmFormExpr
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

        public string Expression
        {
            [MethodImpl(Inline)]
            get => AsmSigs.format(this);
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

        public AsmMnemonic Mnemonic
        {
            [MethodImpl(Inline)]
            get => Sig.Mnemonic;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsmFormExpr src)
            => OpCode == src.OpCode && Sig == src.Sig;

        public override bool Equals(object src)
            => src is AsmFormExpr x && Equals(x);

        public override int GetHashCode()
            => (int)alg.hash.combine(OpCode.GetHashCode(), Sig.GetHashCode());

        public string Format()
            => Expression;

        public override string ToString()
            => Format();

        public static AsmFormExpr Empty
            => new AsmFormExpr(AsmOpCodeExpr.Empty, AsmSigExpr.Empty);
    }
}