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
            var monic = src.Mnemonic;
            dst.AppendFormat("{0} ", monic.Format(MnemonicCase.Lowercase));
            for(var i=0; i<count; i++)
            {
                dst.Append(memory.skip(operands,i).Symbol.Format());
                if(i != count - 1)
                    dst.Append(Chars.Comma);
            }
        }

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
            get => new AsmSig(AsmMnemonic.Empty, sys.empty<AsmSigOp>());
        }
    }
}