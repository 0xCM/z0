//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
     using SM = AsmSyntaxMeaning;

    /// <summary>
    /// Classifies composite operand signature specifications
    /// </summary>
    [SymbolSource]
    public enum CompositeSigToken : byte
    {
        [Symbol("")]
        None = 0,

        [Symbol("r/m8", SM.rm8)]
        Rm8,

        [Symbol("r/m16", SM.rm8)]
        Rm16,

        [Symbol("r/m32", SM.rm8)]
        Rm32,

        [Symbol("r/m64", SM.rm8)]
        Rm64,

        [Symbol("reg/m8")]
        RegM8,

        [Symbol("reg/m16")]
        RegM16,

        [Symbol("reg/m32")]
        RegM32,

        [Symbol("reg")]
        Reg,

        [Symbol("m", SM.m)]
        M,

        [Symbol("mem")]
        Mem,
    }
}