//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public enum DirectiveKind : byte
    {
        None = 0,

        [Symbol(".section")]
        Section,

        [Symbol(".file")]
        File,

        [Symbol(".globl")]
        Global,

        [Symbol(".p2align")]
        P2Align,

        [Symbol(".def")]
        Def,

        [Symbol(".endef")]
        EndDef,

        [Symbol(".scl")]
        Scl,

        [Symbol(".type")]
        Type,
    }
}