//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmForm
    {
        public AsmOpCodeExpr OpCode {get;}

        public AsmSig Sig {get;}

        [MethodImpl(Inline)]
        internal AsmForm(AsmOpCodeExpr opcode, AsmSig sig)
        {
            OpCode = opcode;
            Sig = sig;
        }

        public string Expression
        {
            [MethodImpl(Inline)]
            get => string.Format("{0} -> {1}", Sig, OpCode);
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
        public bool Equals(AsmForm src)
            => OpCode == src.OpCode && Sig == src.Sig;

        public override bool Equals(object src)
            => src is AsmForm x && Equals(x);

        public override int GetHashCode()
            => (int)alg.hash.combine(OpCode.GetHashCode(), Sig.GetHashCode());

        public string Format()
            => Expression;

        public override string ToString()
            => Format();

        public static AsmForm Empty
            => new AsmForm(AsmOpCodeExpr.Empty, AsmSig.Empty);
    }

}