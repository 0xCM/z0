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
            public SizeQualifierKind Kind => SizeQualifierKind.Byte;
        }

        public readonly struct Word
        {
            public SizeQualifierKind Kind => SizeQualifierKind.Word;
        }

        public readonly struct DWord
        {
            public SizeQualifierKind Kind => SizeQualifierKind.DWord;

        }

        public readonly struct QWord
        {
            public SizeQualifierKind Kind => SizeQualifierKind.QWord;
        }

        public readonly struct XmmWord
        {
            public SizeQualifierKind Kind => SizeQualifierKind.XmmWord;
        }

        public readonly struct YmmWord
        {
            public SizeQualifierKind Kind => SizeQualifierKind.YmmWord;
        }

        public readonly struct ZmmWord
        {
            public SizeQualifierKind Kind => SizeQualifierKind.ZmmWord;
        }
    }
}