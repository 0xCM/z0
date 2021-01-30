//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SQ = AsmSizeQualifier;
    using N = AsmKeywordNames;

    public readonly struct AsmDataTypes
    {
        public readonly struct AsmByte : IAsmDataType<AsmByte>
        {
            public AsmSizeQualifier Kind => SQ.Byte;

            public Name Name => N.Byte;
        }

        public readonly struct Word : IAsmDataType<Word>
        {
            public AsmSizeQualifier Kind => SQ.Word;

            public Name Name => N.Word;
        }

        public readonly struct DWord : IAsmDataType<DWord>
        {
            public AsmSizeQualifier Kind => SQ.DWord;

            public Name Name => N.DWord;
        }

        public readonly struct QWord : IAsmDataType<QWord>
        {
            public AsmSizeQualifier Kind => SQ.QWord;

            public Name Name => N.DWord;
        }

        public readonly struct XmmWord : IAsmDataType<XmmWord>
        {
            public AsmSizeQualifier Kind => SQ.XmmWord;

            public Name Name => N.XmmWord;
        }

        public readonly struct YmmWord : IAsmDataType<YmmWord>
        {
            public AsmSizeQualifier Kind => SQ.YmmWord;

            public Name Name => N.YmmWord;
        }

        public readonly struct ZmmWord : IAsmDataType<ZmmWord>
        {
            public AsmSizeQualifier Kind => SQ.ZmmWord;

            public Name Name => N.ZmmWord;
        }
    }

}