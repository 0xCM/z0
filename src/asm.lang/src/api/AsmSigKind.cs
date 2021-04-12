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

        [Symbol("")]
        and_r16_r16,

        [Symbol("")]
        mov_r64_imm64,

        [Symbol("")]
        and_r8_imm8,

        [Symbol("CMP r8, imm8", "80 /7 ib")]
        cmp_r8_imm8,

        [Symbol("CMP r16, imm16", "81 /7 iw")]
        cmp_r16_imm16,

        [Symbol("CMP r32, imm32", "81 /7 id")]
        cmp_r32_imm32,

        [Symbol("CMP r16, r16")]
        cmp_r16_r16,

        [Symbol("CMP r32, r32")]
        cmp_r32_r32,

        [Symbol("CMP r32, r32")]
        cmp_r64_r64,

        vlddqu_xmm_m128,
    }
}