//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Pow2x16;
    using static RegisterKind;

    public enum AsmSigOperandKind : ushort
    {
        None = 0,

        AL,

        AX,

        EAX,

        RAX,

        /// <summary>
        /// A 128-bit bounds register. BND0 through BND3
        /// </summary>
        BND,

        /// <summary>
        /// An 8-bit immediate operand
        /// </summary>
        Imm8,

        /// <summary>
        /// A 16-bit immediate operand
        /// </summary>
        Imm16,

        /// <summary>
        /// A 32-bit immediate operand
        /// </summary>
        Imm32,

        /// <summary>
        /// A 64-bit immediate operand
        /// </summary>
        Imm64,

        /// <summary>
        /// One of the byte general-purpose registers: {AL CL DL BL AH CH DH BH BPL SPL DIL SIL};
        /// or one of the byte registers (R8L-R15L) available when using REX.R and 64-bit mode.
        /// </summary>
        R8,

        /// <summary>
        /// One of the word general-purpose registers: {AX CX DX BX SP BP SI DI}; or one of the word registers
        /// (R8-R15) available when using REX.R and 64-bit mode
        /// </summary>
        R16,

        /// <summary>
        ///One of the doubleword general-purpose registers: {EAX ECX EDX EBX ESP EBP ESI EDI}; or one of the doubleword registers
        /// (R8D - R15D) available when using REX.R in 64-bit mode
        /// </summary>
        R32,

        /// <summary>
        /// One of the quadword general-purpose registers: {RAX RBX RCX RDX RDI RSI RBP RSP R8–R15}, are available when using REX.R and 64-bit mode
        /// </summary>
        R64,

        /// <summary>
        /// A byte operand that is either the contents of a byte general-purpose register: {AL CL DL BL AH CH DH BH BPL SPL DIL SIL};
        /// or a byte from memory. Byte registers R8L - R15L are available using REX.R in 64-bit mode
        /// </summary>
        Rm8,

        /// <summary>
        /// A word general-purpose register or memory operand used for instructions whose operand-size attribute is 16 bits.
        /// The word general-purpose registers are: AX, CX, DX, BX, SP, BP, SI, DI. The contents of memory are found at the address
        /// provided by the effective address computation. Word registers R8W - R15W are available using REX.R in 64-bit mode
        /// </summary>
        Rm16,

        /// <summary>
        /// A doubleword general-purpose register or memory operand used for instructions whose operand size attribute is 32 bits.
        /// The doubleword general-purpose registers are: EAX, ECX, EDX, EBX, ESP, EBP, ESI, EDI. The contents of memory are found
        /// at the address provided by the effective address computation.
        /// Doubleword registers R8D - R15D are available when using REX.R in 64-bit mode
        /// </summary>
        Rm32,

        /// <summary>
        /// A quadword general-purpose register or memory operand used for instructions whose operand-size attribute is 64 bits
        /// when using REX.W. Quadword general-purpose registers are: RAX, RBX, RCX, RDX, RDI, RSI, RBP, RSP, R8–R15;
        /// these are available only in 64-bit mode. The contents of memory are found at the address provided by the
        /// effective address computation
        /// </summary>
        Rm64,

        /// <summary>
        /// An operand in memory of width 16, 32 or 64 bits
        /// </summary>
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
        M8,

        /// <summary>
        /// A 16-bit operand in memory pointed to by a register, and applicable only to string instructions
        /// </summary>
        /// <remarks>
        /// The register is one of
        /// <see cref='DS'/><see cref='SI'/>
        /// <see cref='DS'/>:<see cref='ESI'/>
        /// </remarks>
        M16,

        /// <summary>
        /// A 32-bit operand in memory pointed to by a register, and applicable only to string instructions
        /// </summary>
        /// <remarks>
        /// The register is one of
        /// <see cref='DS'/><see cref='SI'/>
        /// <see cref='DS'/>:<see cref='ESI'/>
        /// </remarks>
        M32,

        /// <summary>
        /// A 64-bit operand in memory
        /// </summary>
        M64,

        /// <summary>
        /// A 128-bit operand in memory
        /// </summary>
        M128,

        /// <summary>
        /// A 256-bit operand in memory
        /// </summary>
        M256,

        /// <summary>
        /// A word integer operand in memory and designates integers that are used as operands for x87 FPU integer instructions
        /// </summary>
        M16Int,

        /// <summary>
        /// A doubleword integer operand in memory and designates integers that are used as operands for x87 FPU integer instructions
        /// </summary>
        M32Int,

        /// <summary>
        /// A quadword integer operand in memory and designates integers that are used as operands for x87 FPU integer instructions
        /// </summary>
        M64Int,

        /// <summary>
        /// An mmx register
        /// </summary>
        MM,

        /// <summary>
        /// An XMM register. The 128-bit XMM registers are: XMM0 through XMM7; XMM8 through XMM15 are available using REX.R in 64-bit mode.
        /// </summary>
        Xmm,

        /// <summary>
        /// An XMM register or a 32-bit memory operand. The 128-bit XMM registers are XMM0 through XMM7; XMM8 through XMM15 are available
        /// using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation
        /// </summary>
        Xmm32,

        /// <summary>
        /// An XMM register or a 64-bit memory operand. The 128-bit SIMD floating-point registers are XMM0 through XMM7; XMM8 through XMM15 are available
        /// using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation
        /// </summary>
        Xmm64,

        /// <summary>
        /// An XMM register or a 128-bit memory operand. The 128-bit XMM registers are XMM0 through XMM7; XMM8 through XMM15 are available
        /// using REX.R in 64-bit mode. The contents of memory are found at the address provided by the effective address computation
        /// </summary>
        Xmm128,

        /// <summary>
        /// A first xmm register operand
        /// </summary>
        Xmm1,

        /// <summary>
        /// A second xmm register operand
        /// </summary>
        Xmm2,

        /// <summary>
        /// A third xmm register operand
        /// </summary>
        Xmm3,

        /// <summary>
        /// A YMM register. The 256-bit YMM registers are: YMM0 through YMM7; YMM8 through YMM15 are available in 64-bit mode
        /// </summary>
        Ymm,

        /// <summary>
        /// A first ymm register operand
        /// </summary>
        Ymm1,

        /// <summary>
        /// A second ymm register operand
        /// </summary>
        Ymm2,

        /// <summary>
        /// A third ymm register operand
        /// </summary>
        Ymm3,

        /// <summary>
        /// A memory operand containing a far pointer composed of two numbers. The left value
        /// corresponds to the pointer's segment selector and the right corresponds to its offset
        /// </summary>
        m16x16,

        /// <summary>
        /// A memory operand containing a far pointer composed of two numbers. The left value
        /// corresponds to the pointer's segment selector and the right corresponds to its offset
        /// </summary>
        m16x32,

        /// <summary>
        /// A memory operand containing a far pointer composed of two numbers. The left value
        /// corresponds to the pointer's segment selector and the right corresponds to its offset
        /// </summary>
        m16x64,

        /// <summary>
        /// A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand.
        /// All memory addressing modes are allowed. Ussed by the BOUND instruction to provide an operand containing an
        /// upper and lower bounds for array indices.
        /// </summary>
        md16x16,

        /// <summary>
        /// A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand.
        /// All memory addressing modes are allowed. The operand is used by the BOUND instruction to provide an operand containing an
        /// upper and lower bounds for array indices.
        /// </summary>
        md16x32,

        /// <summary>
        /// A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand.
        /// All memory addressing modes are allowed.
        /// </summary>
        md32x32,

        /// <summary>
        /// A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand.
        /// All memory addressing modes are allowed. The operand is used by LIDT and LGDT in 64-bit mode to provide a word with which
        /// to load the limit field, and a quadword with which to load the base field of the corresponding GDTR and IDTR registers
        /// </summary>
        md16x64,

        /// <summary>
        /// A relative address in the range from 128 bytes before the end of the instruction to 127 bytes after the end of the instruction
        /// </summary>
        Rel8,

        /// <summary>
        /// A relative address within the same code segment as the instruction assembled. The rel16 symbol applies to instructions
        /// with an operand-size attribute of 16 bits
        /// </summary>
        Rel16,

        /// <summary>
        /// A relative address within the same code segment as the instruction assembled. The rel32 symbol applies to instructions
        /// with an operand-size attribute of 32 bits
        /// </summary>
        Rel32,

        /// <summary>
        /// A segment register. The segment register bit assignments are ES = 0, CS = 1, SS = 2, DS = 3, FS = 4, and GS = 5
        /// </summary>
        Sreg,

        /// <summary>
        /// </summary>
        Moffs8,

        /// <summary>
        /// </summary>
        Moffs16,

        /// <summary>
        /// </summary>
        Moffs32,

        /// <summary>
        /// </summary>
        Moffs64,

        /// <summary>
        /// A far pointer typically to a code segment different from that of the instruction. The notation 16:16 indicates that the
        /// value of the pointer has two parts. The value to the left of the colon is a 16- bit selector or value destined
        /// for the code segment register. The value to the right corresponds to the offset within the destination segment.
        /// The ptr16:16 symbol is used when the instruction's operand-size attribute is 16 bits
        /// </summary>
        Ptr16x16,

        /// <summary>
        /// A far pointer typically to a code segment different from that of the instruction and similar to ptr16:16 notation;
        /// in this case the ptr16:32 symbol is used when the operand-size attribute is 32 bits
        /// A memory operand using SIB addressing form, where the index register is not used in address calculation, Scale is ignored.
        /// Only the base and displacement are used in effective address calculation
        /// </summary>
        Ptr16x32,

        /// <summary>
        /// A memory operand using SIB addressing form, where the index register is not used in address calculation, Scale is ignored.
        /// Only the base and displacement are used in effective address calculation
        /// </summary>
        Mib,

        /// <summary>
        /// A vector memory operand; the operand size is dependent on the instruction
        /// </summary>
        MV,

        RegClass = P2ᐞ08,

        MemClass = P2ᐞ09,

        RmClass = RegClass | MemClass,

        ImmClass = P2ᐞ11,
    }
}