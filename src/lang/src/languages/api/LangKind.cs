//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [SymSource]
    public enum LangKind : byte
    {
        None,

        [Symbol(LangNames.Cs)]
        Cs,

        [Symbol(LangNames.Cpp)]
        Cpp,

        [Symbol(LangNames.C)]
        C,

        [Symbol(LangNames.Asm)]
        Asm
    }
}