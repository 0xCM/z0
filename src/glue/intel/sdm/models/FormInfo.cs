//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct IntelSdm
    {
        public struct FormInfo
        {
            public static FormInfo init(AsmMnemonic mnemonic)
            {
                var dst = new FormInfo();
                dst.Mnemonic = mnemonic;
                return dst;
            }

            public AsmMnemonic Mnemonic;

            public AsmOpCodeExpr OpCode;

            public AsmSigExpr Sig;

            public string EncodingKey;

            public string Mode64;

            public string LegacyMode;

            public string Description;
        }
    }
}