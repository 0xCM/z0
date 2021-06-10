//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct AsmSigTokens
    {
       [SymbolSource]
        public enum Reg : byte
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

        [SymbolSource]
        public enum Imm : byte
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

        [SymbolSource]
        public enum Mem : byte
        {
            [Symbol("m", "An operand in memory of width 16, 32 or 64 bits")]
            m,

            [Symbol("mem")]
            mem,

            [Symbol("m8", "A byte operand in memory ( usually expressed as a variable or array name) but pointed to by the DS:(E)SI or ES:(E)DI registers. In 64-bit mode, it is pointed to by the RSI or RDI registers")]
            m8,

            [Symbol("m16", "A word operand in memory (usually expressed as a variable or array name) but pointed to by the DS:(E)SI or ES:(E)DI registers. This nomenclature is used only with the string instructions")]
            m16,

            [Symbol("m32", "A doubleword operand in memory (usually expressed as a variable or array name) but pointed to by the DS:(E)SI or ES:(E)DI registers. This nomenclature is used only with the string instructions")]
            m32,

            [Symbol("m64", "A 64-bit operand in memory")]
            m64,

            [Symbol("m128", "A memory double quadword operand in memory")]
            m128,

            [Symbol("m256", "A 256-bit operand in memory. This nomenclature is used only with AVX instructions")]
            m256,

            [Symbol("m16int", "A word integer operand in memory. These symbols designate integers that are used as operands for x87 FPU integer instructions")]
            m16Int,

            [Symbol("m32int", "A doubleword integer operand in memory. These symbols designate integers that are used as operands for x87 FPU integer instructions")]
            m32Int,

            [Symbol("m64int", "A quadword integer operand in memory. These symbols designate integers that are used as operands for x87 FPU integer instructions")]
            m64Int,

            [Symbol("m16&16", "A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand.")]
            m16x16,

            [Symbol("m16&32", "A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand.")]
            m16x32,
        }

        [SymbolSource]
        public enum Rm : byte
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

        [SymbolSource]
        public enum Ptr : byte
        {
            /// <summary>
            /// A far pointer typically to a code segment different from that of the instruction. The notation 16:16 indicates that the
            /// value of the pointer has two parts. The value to the left of the colon is a 16- bit selector or value destined
            /// for the code segment register. The value to the right corresponds to the offset within the destination segment.
            /// The ptr16:16 symbol is used when the instruction's operand-size attribute is 16 bits
            /// E.G, CALL ptr16:16 (Call far, absolute, address given in operand)
            /// </summary>
            [Symbol("ptr16:16")]
            ptr16x16,

            /// <summary>
            /// A far pointer typically to a code segment different from that of the instruction and similar to ptr16:16 notation;
            /// in this case the ptr16:32 symbol is used when the operand-size attribute is 32 bits
            /// A memory operand using SIB addressing form, where the index register is not used in address calculation, Scale is ignored.
            /// Only the base and displacement are used in effective address calculation
            /// E.G, CALL ptr16:32 (Call far, absolute, address given in operand)
            /// </summary>
            [Symbol("ptr16:32")]
            ptr16x32,
        }

        [SymbolSource]
        public enum Moffs : byte
        {
            [Symbol("moffs8", "A simple memory variable (memory offset) of type byte, word, or doubleword used by some variants of the MOV instruction. The actual address is given by a simple offset relative to the segment base. No ModR/M byte is used in the instruction. The number shown with moffs indicates its size, which is determined by the address-size attribute of the instruction")]
            moffs8,

            [Symbol("moffs16", "A simple memory variable (memory offset) of type byte, word, or doubleword used by some variants of the MOV instruction. The actual address is given by a simple offset relative to the segment base. No ModR/M byte is used in the instruction. The number shown with moffs indicates its size, which is determined by the address-size attribute of the instruction")]
            moffs16,

            [Symbol("moffs32", "A simple memory variable (memory offset) of type byte, word, or doubleword used by some variants of the MOV instruction. The actual address is given by a simple offset relative to the segment base. No ModR/M byte is used in the instruction. The number shown with moffs indicates its size, which is determined by the address-size attribute of the instruction")]
            moffs32,

            [Symbol("moffs64", "A simple memory variable (memory offset) of type byte, word, or doubleword used by some variants of the MOV instruction. The actual address is given by a simple offset relative to the segment base. No ModR/M byte is used in the instruction. The number shown with moffs indicates its size, which is determined by the address-size attribute of the instruction")]
            moffs64,
        }

        [SymbolSource]
        public enum Rel : byte
        {
            [Symbol("rel8", "A relative address in the range from 128 bytes before the end of the instruction to 127 bytes after the end of the instruction")]
            rel8,

            [Symbol("rel16", "A relative address within the same code segment as the instruction assembled. The rel16 symbol applies to instructions with an operand-size attribute of 16 bits")]
            rel16,

            [Symbol("rel32", "A relative address within the same code segment as the instruction assembled. The rel32 symbol applies to instructions with an operand-size attribute of 32 bits")]
            rel32,
        }

        [SymbolSource]
        public enum AddressingMode : byte
        {
            [Symbol("m16b")]
            Mode16,

            [Symbol("m32b")]
            Mode32,

            [Symbol("m64b")]
            Mode64,
        }

        [SymbolSource]
        public enum SegOverride : byte
        {
            [Symbol("cs", "CS segment override")]
            CS,

            [Symbol("ss", "SS segment override")]
            SS,

            [Symbol("ds", "DS segment override")]
            DS,

            [Symbol("es", "ES segment override")]
            ES,

            [Symbol("fs", "FS segment override")]
            FS,

            [Symbol("gs", "GS segment override")]
            GS,
        }
    }
}