//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct AsmSizeQualifiers
    {
        public readonly struct Byte
        {
            public AsmSizeQualifier Kind => AsmSizeQualifier.Byte;
        }

        public readonly struct Word
        {
            public AsmSizeQualifier Kind => AsmSizeQualifier.Word;
        }

        public readonly struct DWord
        {
            public AsmSizeQualifier Kind => AsmSizeQualifier.DWord;

        }

        public readonly struct QWord
        {
            public AsmSizeQualifier Kind => AsmSizeQualifier.QWord;
        }

        public readonly struct XmmWord
        {
            public AsmSizeQualifier Kind => AsmSizeQualifier.XmmWord;
        }

        public readonly struct YmmWord
        {
            public AsmSizeQualifier Kind => AsmSizeQualifier.YmmWord;
        }

        public readonly struct ZmmWord
        {
            public AsmSizeQualifier Kind => AsmSizeQualifier.ZmmWord;
        }
    }
}