//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using K = AsmSizeQualifier;
    using N = AsmKeywordNames;

    partial struct AsmLang
    {
        public readonly struct SizeQualifiers
        {
            public readonly struct Byte : IAsmKeyword<Byte,K>
            {
                public AsmSizeQualifier Kind => K.Byte;

                public Name Name => N.Byte;
            }

            public readonly struct Word : IAsmKeyword<Word,K>
            {
                public AsmSizeQualifier Kind => K.Word;

                public Name Name => N.Word;
            }

            public readonly struct DWord : IAsmKeyword<DWord,K>
            {
                public AsmSizeQualifier Kind => K.DWord;

                public Name Name => N.DWord;
            }

            public readonly struct QWord : IAsmKeyword<QWord,K>
            {
                public AsmSizeQualifier Kind => K.QWord;

                public Name Name => N.DWord;
            }

            public readonly struct XmmWord : IAsmKeyword<XmmWord,K>
            {
                public AsmSizeQualifier Kind => K.XmmWord;

                public Name Name => N.XmmWord;
            }

            public readonly struct YmmWord : IAsmKeyword<YmmWord,K>
            {
                public AsmSizeQualifier Kind => K.YmmWord;

                public Name Name => N.YmmWord;
            }

            public readonly struct ZmmWord : IAsmKeyword<ZmmWord,K>
            {
                public AsmSizeQualifier Kind => K.ZmmWord;

                public Name Name => N.ZmmWord;
            }
        }
    }
}