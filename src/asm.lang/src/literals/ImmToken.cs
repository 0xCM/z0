//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [SymbolSource]
    public enum ImmToken : byte
    {
        [Symbol("imm8", "An immediate 8-bit value in the inclusive range [–128, 127]. For instructions in which imm8 is combined with a word or doubleword operand, the immediate value is sign-extended to form a word or doubleword. The upper byte of the word is filled with the topmost bit of the immediate value")]
        imm8,

        [Symbol("imm16", "An immediate value for a 16-bit operand in the inclusive range [–32_768, 32_767]")]
        imm16,

        [Symbol("imm32", "An immediate value for a 16-bit operand in the inclusive range [–32_768, 32_767]")]
        imm32,

        [Symbol("imm64", "An immediate value for a 64-bit operand in the inclusive range [–9_223_372_036_854_775_808, 9_223_372_036_854_775_807]")]
        imm64,
    }
}
