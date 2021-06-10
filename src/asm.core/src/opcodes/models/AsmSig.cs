//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmSig
    {
        public AsmMnemonic Mnemonic {get;}

        public Index<AsmSigOp> Operands {get;}

        [MethodImpl(Inline)]
        public AsmSig(AsmMnemonic monic, Index<AsmSigOp> operands)
        {
            Mnemonic = monic;
            Operands = operands;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Mnemonic.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Mnemonic.IsNonEmpty;
        }

        public string Format()
            => AsmRender.format(this);

        public override string ToString()
            => Format();

        public static AsmSig Empty
        {
            [MethodImpl(Inline)]
            get => new AsmSig(AsmMnemonic.Empty, sys.empty<AsmSigOp>());
        }
    }
}