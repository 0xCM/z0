//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public enum AsmSigKind : ushort
    {
        None = 0,

        [Symbol("","")]
        and_r8_r8,

        [Symbol("","")]
        and_r16_r16,

        [Symbol("","")]
        mov_r64_imm64,

        [Symbol("","")]
        and_r8_imm8
    }
}