//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Pow2x16;
    using static RegisterKind;

    public enum AsmSigOpKind : ushort
    {
        None = 0,

        [Symbol("al")]
        AL,

        [Symbol("ax")]
        AX,

        [Symbol("eax")]
        EAX,

        [Symbol("rax")]
        RAX,

        /// <summary>
        /// A 128-bit bounds register. BND0 through BND3
        /// </summary>
        [Symbol("bnd")]
        BND,

        /// <summary>
        /// An 8-bit immediate operand
        /// </summary>
        [Symbol("imm8")]
        Imm8,

        /// <summary>
        /// A 16-bit immediate operand
        /// </summary>
        [Symbol("imm16")]
        Imm16,

        /// <summary>
        /// A 32-bit immediate operand
        /// </summary>
        [Symbol("imm32")]
        Imm32,

        /// <summary>
        /// A 64-bit immediate operand
        /// </summary>
        [Symbol("imm64")]
        Imm64,

        /// <summary>
        /// One of the byte general-purpose registers: {AL CL DL BL AH CH DH BH BPL SPL DIL SIL};
        /// or one of the byte registers (R8L-R15L) available when using REX.R and 64-bit mode.
        /// </summary>
        [Symbol("r8")]
        R8,

        /// <summary>
        /// One of the word general-purpose registers: {AX CX DX BX SP BP SI DI}; or one of the word registers
        /// (R8-R15) available when using REX.R and 64-bit mode
        /// </summary>
        [Symbol("r16")]
        R16,

        /// <summary>
        ///One of the doubleword general-purpose registers: {EAX ECX EDX EBX ESP EBP ESI EDI}; or one of the doubleword registers
        /// (R8D - R15D) available when using REX.R in 64-bit mode
        /// </summary>
        [Symbol("r32")]
        R32,

        /// <summary>
        /// One of the quadword general-purpose registers: {RAX RBX RCX RDX RDI RSI RBP RSP R8–R15}, are available when using REX.R and 64-bit mode
        /// </summary>
        [Symbol("r64")]
        R64,

        /// <summary>
        /// A byte operand that is either the contents of a byte general-purpose register: {AL CL DL BL AH CH DH BH BPL SPL DIL SIL};
        /// or a byte from memory. Byte registers R8L - R15L are available using REX.R in 64-bit mode
        /// </summary>
        [Symbol("r/m8")]
        Rm8,

        /// <summary>
        /// A word general-purpose register or memory operand used for instructions whose operand-size attribute is 16 bits.
        /// The word general-purpose registers are: AX, CX, DX, BX, SP, BP, SI, DI. The contents of memory are found at the address
        /// provided by the effective address computation. Word registers R8W - R15W are available using REX.R in 64-bit mode
        /// </summary>
        [Symbol("r/m16")]
        Rm16,

        /// <summary>
        /// A doubleword general-purpose register or memory operand used for instructions whose operand size attribute is 32 bits.
        /// The doubleword general-purpose registers are: EAX, ECX, EDX, EBX, ESP, EBP, ESI, EDI. The contents of memory are found
        /// at the address provided by the effective address computation.
        /// Doubleword registers R8D - R15D are available when using REX.R in 64-bit mode
        /// </summary>
        [Symbol("r/m32")]
        Rm32,

        /// <summary>
        /// A quadword general-purpose register or memory operand used for instructions whose operand-size attribute is 64 bits
        /// when using REX.W. Quadword general-purpose registers are: RAX, RBX, RCX, RDX, RDI, RSI, RBP, RSP, R8–R15;
        /// these are available only in 64-bit mode. The contents of memory are found at the address provided by the
        /// effective address computation
        /// </summary>
        [Symbol("r/m64")]
        Rm64,

        /// <summary>
        /// An operand in memory of width 16, 32 or 64 bits
        /// EG
        /// LEA r16, m
        /// LEA r32, m
        /// LEA r64, m
        /// </summary>
        [Symbol("m")]
        M,

        /// <summary>
        /// An 8-bit operand in memory of width pointed to by a register that is <see cref='AsmOperatingMode'/> dependent
        /// </summary>
        /// <remarks>
        /// For <see cref='AsmOperatingMode.Non64'/> mode, is pointed to by one of
        /// <see cref='DS'/>:<see cref='SI'/>
        /// <see cref='DS'/>:<see cref='ESI'/>
        /// <see cref='ES'/>:<see cref='DI'/>
        /// <see cref='ES'/>:<see cref='EDI'/>
        /// For <see cref='AsmOperatingMode.Mode64'/>, it is pointed to by one of
        /// <see cref='RSI'/>
        /// <see cref='RDI'/>
        /// </remarks>
        [Symbol("m8")]
        M8,

        /// <summary>
        /// A 16-bit operand in memory pointed to by a register, and applicable only to string instructions
        /// </summary>
        /// <remarks>
        /// The register is one of
        /// <see cref='DS'/><see cref='SI'/>
        /// <see cref='DS'/>:<see cref='ESI'/>
        /// </remarks>
        [Symbol("m16")]
        M16,

        /// <summary>
        /// A 32-bit operand in memory pointed to by a register, and applicable only to string instructions
        /// </summary>
        /// <remarks>
        /// The register is one of
        /// <see cref='DS'/><see cref='SI'/>
        /// <see cref='DS'/>:<see cref='ESI'/>
        /// </remarks>
        [Symbol("m32")]
        M32,

        /// <summary>
        /// A 64-bit operand in memory
        /// </summary>
        [Symbol("m64")]
        M64,

        /// <summary>
        /// A 128-bit operand in memory
        /// </summary>
        [Symbol("m128")]
        M128,

        /// <summary>
        /// A 256-bit operand in memory
        /// </summary>
        [Symbol("m256")]
        M256,

        /// <summary>
        /// A word integer operand in memory and designates integers that are used as operands for x87 FPU integer instructions
        /// </summary>
        [Symbol("m16int")]
        M16Int,

        /// <summary>
        /// A doubleword integer operand in memory and designates integers that are used as operands for x87 FPU integer instructions
        /// </summary>
        [Symbol("m32int")]
        M32Int,

        /// <summary>
        /// A quadword integer operand in memory and designates integers that are used as operands for x87 FPU integer instructions
        /// </summary>
        [Symbol("m64int")]
        M64Int,

        /// <summary>
        /// An mmx register
        /// </summary>
        [Symbol("mm")]
        MM,

        /// <summary>
        /// An XMM register
        /// </summary>
        [Symbol("xmm")]
        Xmm,

        /// <summary>
        /// A first xmm register operand
        /// </summary>
        [Symbol("xmm1")]
        Xmm1,

        /// <summary>
        /// A second xmm register operand
        /// </summary>
        [Symbol("xmm2")]
        Xmm2,

        /// <summary>
        /// A third xmm register operand
        /// </summary>
        [Symbol("xmm3")]
        Xmm3,

        /// <summary>
        /// An XMM register or a 32-bit memory operand. The 128-bit XMM registers are XMM0 through XMM7; XMM8 through XMM15 are available
        /// using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation
        /// </summary>
        [Symbol("xmm32")]
        Xmm32,

        /// <summary>
        /// An XMM register or a 64-bit memory operand. The 128-bit SIMD floating-point registers are XMM0 through XMM7; XMM8 through XMM15 are available
        /// using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation
        /// </summary>
        [Symbol("xmm64")]
        Xmm64,

        /// <summary>
        /// An XMM register or a 128-bit memory operand. The 128-bit XMM registers are XMM0 through XMM7; XMM8 through XMM15 are available
        /// using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation
        /// </summary>
        [Symbol("xmm128")]
        Xmm128,

        /// <summary>
        /// A YMM register
        /// </summary>
        [Symbol("ymm")]
        Ymm,

        /// <summary>
        /// A first ymm register operand
        /// </summary>
        [Symbol("ymm1")]
        Ymm1,

        /// <summary>
        /// A second ymm register operand
        /// </summary>
        [Symbol("ymm2")]
        Ymm2,

        /// <summary>
        /// A third ymm register operand
        /// </summary>
        [Symbol("ymm3")]
        Ymm3,

        /// <summary>
        /// A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand.
        /// All memory addressing modes are allowed. Ussed by the BOUND instruction to provide an operand containing an
        /// upper and lower bounds for array indices, E.G. BOUND r16, m16&16
        /// </summary>
        [Symbol("m16&16")]
        m16x16,

        /// <summary>
        /// A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand.
        /// All memory addressing modes are allowed. The operand is used by the BOUND instruction to provide an operand containing an
        /// upper and lower bounds for array indices.
        /// </summary>
        [Symbol("m16&32")]
        m16x32,

        /// <summary>
        /// A relative address in the range from 128 bytes before the end of the instruction to 127 bytes after the end of the instruction
        /// </summary>
        [Symbol("rel8")]
        Rel8,

        /// <summary>
        /// A relative address within the same code segment as the instruction assembled. The rel16 symbol applies to instructions
        /// with an operand-size attribute of 16 bits
        /// </summary>
        [Symbol("rel16")]
        Rel16,

        /// <summary>
        /// A relative address within the same code segment as the instruction assembled. The rel32 symbol applies to instructions
        /// with an operand-size attribute of 32 bits
        /// </summary>
        [Symbol("rel32")]
        Rel32,

        /// <summary>
        /// A segment register. The segment register bit assignments are ES = 0, CS = 1, SS = 2, DS = 3, FS = 4, and GS = 5
        /// </summary>
        [Symbol("Sreg")]
        Sreg,

        /// <summary>
        /// </summary>
        [Symbol("moffs8")]
        Moffs8,

        /// <summary>
        /// </summary>
        [Symbol("moffs16")]
        Moffs16,

        /// <summary>
        /// </summary>
        [Symbol("moffs32")]
        Moffs32,

        /// <summary>
        /// </summary>
        [Symbol("moffs64")]
        Moffs64,

        /// <summary>
        /// A far pointer typically to a code segment different from that of the instruction. The notation 16:16 indicates that the
        /// value of the pointer has two parts. The value to the left of the colon is a 16- bit selector or value destined
        /// for the code segment register. The value to the right corresponds to the offset within the destination segment.
        /// The ptr16:16 symbol is used when the instruction's operand-size attribute is 16 bits
        /// E.G, CALL ptr16:16 (Call far, absolute, address given in operand)
        /// </summary>
        [Symbol("ptr16:16")]
        Ptr16x16,

        /// <summary>
        /// A far pointer typically to a code segment different from that of the instruction and similar to ptr16:16 notation;
        /// in this case the ptr16:32 symbol is used when the operand-size attribute is 32 bits
        /// A memory operand using SIB addressing form, where the index register is not used in address calculation, Scale is ignored.
        /// Only the base and displacement are used in effective address calculation
        /// E.G, CALL ptr16:32 (Call far, absolute, address given in operand)
        /// </summary>
        [Symbol("ptr16:32")]
        Ptr16x32,

        /// <summary>
        /// A mask register used as a regular operand (either destination or source). The 64-bit k registers are: k0 through k7
        /// </summary>
        [Symbol("k1")]
        K1,

        RegClass = P2ᐞ08,

        MemClass = P2ᐞ09,

        RmClass = RegClass | MemClass,

        ImmClass = P2ᐞ11,
    }
}