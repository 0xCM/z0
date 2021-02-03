//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmSpecifierExpr
    {
        public ushort Seq {get;}

        public AsmSigExpr Sig {get;}

        public AsmOpCodeExpr OpCode {get;}

        [MethodImpl(Inline)]
        internal AsmSpecifierExpr(ushort seq, AsmOpCodeExpr opcode, AsmSigExpr sig)
        {
            OpCode = opcode;
            Sig = sig;
            Seq = seq;
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
        public bool Equals(AsmSpecifierExpr src)
            => OpCode == src.OpCode && Sig == src.Sig;

        public override bool Equals(object src)
            => src is AsmSpecifierExpr x && Equals(x);

        public override int GetHashCode()
            => (int)alg.hash.combine(OpCode.GetHashCode(), Sig.GetHashCode());

        public string Format()
            => string.Format("{0,-8} | {1,-64} | {2}", Seq, Sig.Format(), OpCode.Format());

        public override string ToString()
            => Format();

        public static AsmSpecifierExpr Empty
            => new AsmSpecifierExpr(0, AsmOpCodeExpr.Empty, AsmSigExpr.Empty);
    }
}