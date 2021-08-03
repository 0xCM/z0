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
            @byte,

            [Symbol("word")]
            word,

            [Symbol("dword")]
            dword,

            [Symbol("qword")]
            qword,

            [Symbol("xmmword")]
            xmmword,

            [Symbol("ymmword")]
            ymmword,

            [Symbol("zmmword")]
            zmmword,
        }
    }
}