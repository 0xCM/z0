//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmFormExpr : ISyntaxPart<AsmFormExpr>
    {
        public AsmOpCodeExpr OpCode {get;}

        public AsmSigExpr Sig {get;}

        [MethodImpl(Inline)]
        public AsmFormExpr(AsmOpCodeExpr opcode, AsmSigExpr sig)
        {
            OpCode = opcode;
            Sig = sig;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => OpCode.IsEmpty || Sig.IsEmpty;
        }

        public TextBlock Content
        {
            [MethodImpl(Inline)]
            get => string.Format("({0})<{1}>", Sig, OpCode);
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
            => (int)FastHash.combine(OpCode.GetHashCode(), Sig.GetHashCode());

        public string Format()
            => Content;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmFormExpr((AsmOpCodeExpr oc, AsmSigExpr sig) src)
            => new AsmFormExpr(src.oc, src.sig);

        public static AsmFormExpr Empty
            => new AsmFormExpr(AsmOpCodeExpr.Empty, AsmSigExpr.Empty);
    }
}