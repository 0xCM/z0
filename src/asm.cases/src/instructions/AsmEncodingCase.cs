//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmEncodingCase : ITextual
    {
        [MethodImpl(Inline)]
        public static TestCaseId identify(AsmMnemonicCode monic, ushort seq)
            => (ulong)monic |((ulong)seq << 11);

        public TestCaseId Id {get;}

        public AsmExprSet Expr {get;}

        public AsmHexCode Code {get;}

        [MethodImpl(Inline)]
        public AsmEncodingCase(TestCaseId id, AsmExprSet expr, AsmHexCode code)
        {
            Id= id;
            Expr = expr;
            Code = code;
        }

        [MethodImpl(Inline)]
        public AsmEncodingCase(AsmMnemonicCode mnemonic, ushort seq, AsmExprSet expr, AsmHexCode code)
        {
            Id= identify(mnemonic, seq);
            Expr = expr;
            Code = code;
        }

        public AsmMnemonicCode Mnemonic
        {
            [MethodImpl(Inline)]
            get => Id.Segment<AsmMnemonicCode>(0,10);
        }

        public void Render(AsmExprSet src, ITextBuffer dst)
            => dst.AppendFormat("{0} ({1}) | {2}", src.OpCode.Format(), src.Sig.Format(), src.Statement.Format());

        public string Format(AsmExprSet src)
        {
            var dst = text.buffer();
            Render(src, dst);
            return dst.Emit();
        }

        public string Format()
        {
            var seq = Id.Segment<ushort>(11, 16);
            return string.Format("{0}[{1:D4}] | {2} => {3}", Mnemonic, seq, Format(Expr), Code.Format());
        }

        public override string ToString()
            => Format();
    }
}