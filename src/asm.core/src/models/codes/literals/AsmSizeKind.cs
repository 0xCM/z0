//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmCodes
    {
        [SymSource]
        public enum AsmSizeKind : byte
        {
            None=0,

            [Symbol("byte")]
            Byte,

            [Symbol("word")]
            Word,

            [Symbol("xmmword")]
            DWord,

            [Symbol("qword")]
            QWord,

            [Symbol("xmmword")]
            XmmWord,

            [Symbol("ymmword")]
            YmmWord,

            [Symbol("zmmword")]
            ZmmWord,
        }
    }
}