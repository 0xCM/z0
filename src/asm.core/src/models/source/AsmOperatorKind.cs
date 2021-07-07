//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public enum AsmOperatorKind : byte
    {
        None  = 0,

        [Symbol("+")]
        Add,

        [Symbol("-")]
        Sub
    }
}