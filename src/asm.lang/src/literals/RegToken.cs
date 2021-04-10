//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmX
    {
        [SymbolSource]
        public enum RegToken : byte
        {
            [Symbol("reg")]
            reg,

            [Symbol("al")]
            al,

            [Symbol("ax")]
            ax,

            [Symbol("eax")]
            eax,

            [Symbol("rax")]
            rax,

            [Symbol("bnd", "A 128-bit bounds register. BND0 through BND3")]
            bnd,

            [Symbol("r8", "One of the byte general-purpose registers: {AL CL DL BL AH CH DH BH BPL SPL DIL SIL}; or one of the byte registers (R8L-R15L) available when using REX.R and 64-bit mode.")]
            r8,

            [Symbol("r16", "One of the word general-purpose registers: {AX CX DX BX SP BP SI DI}; or one of the word registers (R8-R15) available when using REX.R and 64-bit mode")]
            r16,

            [Symbol("r32", "One of the doubleword general-purpose registers: {EAX ECX EDX EBX ESP EBP ESI EDI}; or one of the doubleword registers (R8D - R15D) available when using REX.R in 64-bit mode")]
            r32,

            [Symbol("r32a", "A first r32 register operand")]
            r32a,

            [Symbol("r32b", "A second r32 register operand")]
            r32b,

            [Symbol("r64", "One of the quadword general-purpose registers: {RAX RBX RCX RDX RDI RSI RBP RSP R8–R15}; These are available when using REX.R and 64-bit mode")]
            r64,

            [Symbol("mm", "An MMX register. The 64-bit MMX registers are: MM0 through MM7. The 64-bit MMX registers are: MM0 through MM7. The contents of memory are found at the address provided by the effective address computation.")]
            mm,

            [Symbol("xmm", "An XMM register. The 128-bit XMM registers are: XMM0 through XMM7; XMM8 through XMM15 are available using REX.R in 64-bit mode.The contents of memory are found at the address provided by the effective address computation")]
            xmm,

            [Symbol("xmm1", "A first xmm register operand")]
            xmm1,

            [Symbol("xmm2", "A second xmm register operand")]
            xmm2,

            [Symbol("xmm3", "A third xmm register operand")]
            xmm3,

            [Symbol("ymm", "A YMM register. The 256-bit YMM registers are: YMM0 through YMM7; YMM8 through YMM15 are available in 64-bit mode")]
            ymm,

            [Symbol("ymm1", "A first ymm register operand")]
            ymm1,

            [Symbol("ymm2", "A second ymm register operand")]
            ymm2,

            [Symbol("ymm3", "A third ymm register operand")]
            ymm3,

            [Symbol("zmm", "A zmm register")]
            zmm,

            [Symbol("Sreg", "A segment register. The segment register bit assignments are ES = 0, CS = 1, SS = 2, DS = 3, FS = 4, and GS = 5")]
            Sreg,

            [Symbol("k1", "A mask register used as a regular operand (either destination or source). The 64-bit k registers are: k0 through k7")]
            k1,
        }
    }
}