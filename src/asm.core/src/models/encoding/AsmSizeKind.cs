//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [SymSource]
    public enum AsmSizeKind : byte
    {
        [Symbol("byte")]
        @byte = 0,

        [Symbol("word")]
        word = 1,

        [Symbol("dword")]
        dword = 2,

        [Symbol("qword")]
        qword = 3,

        [Symbol("xmmword")]
        xmmword = 4,

        [Symbol("ymmword")]
        ymmword = 5,

        [Symbol("zmmword")]
        zmmword = 6,
    }
}