//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmSig
    {
        public static void render(in AsmSig src, ITextBuffer dst)
        {
            var operands = src.Operands.View;
            var count = operands.Length;
            var monic = src.Mnemonic.Expr;
            for(var i=0; i<count; i++)
            {
                dst.Append(memory.skip(operands,i).Symbol.Format());
                if(i != count - 1)
                    dst.Append(Chars.Comma);
            }
        }

        public Sym<AsmMnemonicCode> Mnemonic {get;}

        public Index<AsmSigOperand> Operands {get;}

        [MethodImpl(Inline)]
        public AsmSig(Sym<AsmMnemonicCode> monic, Index<AsmSigOperand> operands)
        {
            Mnemonic = monic;
            Operands = operands;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Mnemonic.Kind == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Mnemonic.Kind != 0;
        }

        public string Format()
        {
            var dst = text.buffer();
            render(this,dst);
            return dst.Emit();
        }

        public override string ToString()
            => Format();

        public static AsmSig Empty
        {
            [MethodImpl(Inline)]
            get => new AsmSig(Sym<AsmMnemonicCode>.Empty, sys.empty<AsmSigOperand>());
        }
    }
}