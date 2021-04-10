//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmX
    {
        [SymbolSource]
        public enum RmToken : byte
        {
            [Symbol("/r", "Indicates that the ModR/M byte of the instruction contains a register operand and an r/m operand")]
            r,

            [Symbol("r/m8", "A byte operand that is either the contents of a byte general-purpose register: {AL CL DL BL AH CH DH BH BPL SPL DIL SIL}; or a byte from memory. Byte registers R8L - R15L are available using REX.R in 64-bit mode")]
            rm8,

            [Symbol("r/m16", "A word general-purpose register or memory operand used for instructions whose operand-size attribute is 16 bits. The word general-purpose registers are: AX, CX, DX, BX, SP, BP, SI, DI. The contents of memory are found at the address provided by the effective address computation. Word registers R8W - R15W are available using REX.R in 64-bit mode")]
            rm16,

            [Symbol("r/m32", "A doubleword general-purpose register or memory operand used for instructions whose operand size attribute is 32 bits. The doubleword general-purpose registers are: EAX, ECX, EDX, EBX, ESP, EBP, ESI, EDI. The contents of memory are found at the address provided by the effective address computation. Doubleword registers R8D - R15D are available when using REX.R in 64-bit mode")]
            rm32,

            [Symbol("r/m64", "A quadword general-purpose register or memory operand used for instructions whose operand-size attribute is 64 bits when using REX.W. Quadword general-purpose registers are: RAX, RBX, RCX, RDX, RDI, RSI, RBP, RSP, R8–R15; these are available only in 64-bit mode. The contents of memory are found at the address provided by the effective address computation")]
            rm64,

            [Symbol("reg/m8")]
            regM8,

            [Symbol("reg/m16")]
            regM16,

            [Symbol("reg/m32")]
            regM32,

            [Symbol("xmm32", "An XMM register or a 32-bit memory operand. The 128-bit XMM registers are XMM0 through XMM7; XMM8 through XMM15 are available using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation")]
            xmm32,

            [Symbol("xmm64", "An XMM register or a 64-bit memory operand. The 128-bit SIMD floating-point registers are XMM0 through XMM7; XMM8 through XMM15 are available using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation")]
            xmm64,

            [Symbol("xmm128", "An XMM register or a 128-bit memory operand. The 128-bit XMM registers are XMM0 through XMM7; XMM8 through XMM15 are available using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation")]
            xmm128,
        }

    }
}