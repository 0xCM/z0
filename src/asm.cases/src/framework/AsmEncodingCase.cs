//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmEncodingCase : ITextual
    {
        [MethodImpl(Inline)]
        public static TestCaseId identify(AsmMnemonicCode monic, ushort seq)
            => (ulong)monic |((ulong)seq << 11);

        public TestCaseId Id {get;}

        public AsmFormExpr Form {get;}

        public AsmExpr Statement {get;}

        public AsmHexCode Code {get;}

        [MethodImpl(Inline)]
        public AsmEncodingCase(AsmMnemonicCode mnemonic, ushort seq, AsmFormExpr form, AsmExpr statement, AsmHexCode code)
        {
            Id= identify(mnemonic, seq);
            Form = form;
            Statement = statement;
            Code = code;
        }

        public AsmMnemonicCode Mnemonic
        {
            [MethodImpl(Inline)]
            get => Id.Segment<AsmMnemonicCode>(0,10);
        }
        public string Format()
        {
            var seq = Id.Segment<ushort>(11, 16);
            return string.Format("{0}[{1:D4}] | {2} {3} => {4}", Mnemonic, seq, Form, Statement, Code.Format());
        }

        public override string ToString()
            => Format();
    }
}