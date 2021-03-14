//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SQ = AsmSizeQualifier;
    using SS = AsmSyntaxSymbols;

    partial struct AsmSyntax
    {
        public readonly struct Byte : IAsmDataType<Byte>
        {
            public AsmSizeQualifier Kind => SQ.Byte;

            public Name Name => SS.@byte;
        }

        public readonly struct Word : IAsmDataType<Word>
        {
            public AsmSizeQualifier Kind => SQ.Word;

            public Name Name => SS.word;
        }

        public readonly struct DWord : IAsmDataType<DWord>
        {
            public AsmSizeQualifier Kind => SQ.DWord;

            public Name Name => SS.dword;
        }

        public readonly struct QWord : IAsmDataType<QWord>
        {
            public AsmSizeQualifier Kind => SQ.QWord;

            public Name Name => SS.qword;
        }

        public readonly struct XmmWord : IAsmDataType<XmmWord>
        {
            public AsmSizeQualifier Kind => SQ.XmmWord;

            public Name Name => SS.xmmword;
        }

        public readonly struct YmmWord : IAsmDataType<YmmWord>
        {
            public AsmSizeQualifier Kind => SQ.YmmWord;

            public Name Name => SS.ymmword;
        }

        public readonly struct ZmmWord : IAsmDataType<ZmmWord>
        {
            public AsmSizeQualifier Kind => SQ.ZmmWord;

            public Name Name => SS.zmmword;
        }
    }
}