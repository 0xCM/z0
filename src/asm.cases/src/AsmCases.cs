//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public partial class AsmCases : Service<AsmCases>
    {
        [MethodImpl(Inline), Op]
        static AsmText<byte> opcode(string src)
            => AsmText.asmtext(src, AsmTextKind.OpCode);

        [MethodImpl(Inline), Op]
        static AsmText<byte> sig(string src)
            => AsmText.asmtext(src, AsmTextKind.Sig);

        [MethodImpl(Inline), Op]
        static AsmText<byte> rule(string src)
            => AsmText.asmtext(src, AsmTextKind.EncodingRule);

        [MethodImpl(Inline), Op]
        public AsmEncodingCase define(AsmMnemonicCode monic, ushort seq, AsmOpCodeExpr oc, AsmSigExpr sig, AsmExpr statement, string encoding)
            => new AsmEncodingCase(monic, seq, asm.form(oc, sig), statement, encoding);
    }
}