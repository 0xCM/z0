//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmSigDocs;

    /// <summary>
    /// Classifies composite operand signature specifications
    /// </summary>
    [SymbolSource]
    public enum CompositeSigToken : byte
    {
        None = 0,

        [Symbol("r/m8", SD.rm8)]
        rm8,

        [Symbol("r/m16", SD.rm8)]
        rm16,

        [Symbol("r/m32", SD.rm8)]
        rm32,

        [Symbol("r/m64", SD.rm8)]
        rm64,

        [Symbol("reg/m8")]
        regM8,

        [Symbol("reg/m16")]
        regM16,

        [Symbol("reg/m32")]
        regM32,

        [Symbol("reg")]
        reg,

        [Symbol("m", SD.m)]
        m,

        [Symbol("mem")]
        mem,
    }
}