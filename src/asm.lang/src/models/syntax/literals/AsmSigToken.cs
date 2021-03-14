//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SM = AsmSyntaxDocs;

    [SymbolSource]
    public enum AsmSigToken : ushort
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
        /// <see cref='SM.bnd'/>
        /// </summary>
        [Symbol("bnd", SM.bnd)]
        BND,

        /// <summary>
        /// <see cref='SM.imm8'/>
        /// </summary>
        [Symbol("imm8", SM.imm8)]
        Imm8,

        /// <summary>
        /// <see cref='SM.imm16'/>
        /// </summary>
        [Symbol("imm16", SM.imm16)]
        Imm16,

        /// <summary>
        /// <see cref='SM.imm32'/>
        /// </summary>
        [Symbol("imm32", SM.imm32)]
        Imm32,

        /// <summary>
        /// <see cref='SM.imm64'/>
        /// </summary>
        [Symbol("imm64", SM.imm64)]
        Imm64,

        /// <summary>
        /// <see cref='SM.r8'/>
        /// </summary>
        [Symbol("r8", SM.r8)]
        R8,

        /// <summary>
        /// <see cref='SM.r16'/>
        /// </summary>
        [Symbol("r16", SM.r16)]
        R16,

        /// <summary>
        /// <see cref='SM.r32'/>
        /// </summary>
        [Symbol("r32", SM.r32)]
        R32,

        /// <summary>
        /// <see cref='SM.r64'/>
        /// </summary>
        [Symbol("r64", SM.r64)]
        R64,

        /// <summary>
        /// <see cref='SM.rm8'/>
        /// </summary>
        [Symbol("r/m8", SM.rm8)]
        Rm8,

        /// <summary>
        /// <see cref='SM.rm16'/>
        /// </summary>
        [Symbol("r/m16", SM.rm16)]
        Rm16,

        /// <summary>
        /// <see cref='SM.rm32'/>
        /// </summary>
        [Symbol("r/m32", SM.rm32)]
        Rm32,

        /// <summary>
        /// <see cref='SM.rm64'/>
        /// </summary>
        [Symbol("r/m64", SM.rm64)]
        Rm64,

        /// <summary>
        /// <see cref='SM.m'/>
        /// </summary>
        [Symbol("m", SM.m)]
        M,

        /// <summary>
        /// <see cref='SM.m8'/>
        /// </summary>
        [Symbol("m8", SM.m8)]
        M8,

        /// <summary>
        /// A 16-bit operand in memory pointed to by a register, and applicable only to string instructions
        /// </summary>
        [Symbol("m16", SM.m16)]
        M16,

        /// <summary>
        /// A 32-bit operand in memory pointed to by a register, and applicable only to string instructions
        /// </summary>
        [Symbol("m32", SM.m32)]
        M32,

        /// <summary>
        /// <see cref='SM.m64'/>
        /// </summary>
        [Symbol("m64", SM.m64)]
        M64,

        /// <summary>
        /// A 128-bit operand in memory
        /// </summary>
        [Symbol("m128", SM.m128)]
        M128,

        /// <summary>
        /// A 256-bit operand in memory
        /// </summary>
        [Symbol("m256", SM.m256)]
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
        /// <see cref='SM.xmm1'/>
        /// </summary>
        [Symbol("xmm1", SM.xmm1)]
        Xmm1,

        /// <summary>
        /// <see cref='SM.xmm2'/>
        /// </summary>
        [Symbol("xmm2", SM.xmm2)]
        Xmm2,

        /// <summary>
        /// <see cref='SM.xmm3'/>
        /// </summary>
        [Symbol("xmm3", SM.xmm3)]
        Xmm3,

        /// <summary>
        /// <see cref='SM.xmm32'/>
        /// </summary>
        [Symbol("xmm32", SM.xmm32)]
        Xmm32,

        /// <summary>
        /// <see cref='SM.xmm64'/>
        /// </summary>
        [Symbol("xmm64", SM.xmm64)]
        Xmm64,

        /// <summary>
        /// <see cref='SM.xmm128'/>
        /// </summary>
        [Symbol("xmm128", SM.xmm128)]
        Xmm128,

        /// <summary>
        /// <see cref='SM.ymm'/>
        /// </summary>
        [Symbol("ymm", SM.ymm)]
        Ymm,

        /// <summary>
        /// <see cref='SM.ymm1'/>
        /// </summary>
        [Symbol("ymm1", SM.ymm1)]
        Ymm1,

        /// <summary>
        /// <see cref='SM.ymm2'/>
        /// </summary>
        [Symbol("ymm2", SM.ymm2)]
        Ymm2,

        /// <summary>
        /// <see cref='SM.ymm3'/>
        /// </summary>
        [Symbol("ymm3", SM.ymm3)]
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
        /// <see cref='SM.rel8'/>
        /// </summary>
        [Symbol("rel8", SM.rel8)]
        Rel8,

        /// <summary>
        /// <see cref='SM.rel16'/>
        /// </summary>
        [Symbol("rel16", SM.rel16)]
        Rel16,

        /// <summary>
        /// <see cref='SM.rel32'/>
        /// </summary>
        [Symbol("rel32", SM.rel32)]
        Rel32,

        /// <summary>
        /// A segment register, where the register bit assignments are ES = 0, CS = 1, SS = 2, DS = 3, FS = 4, and GS = 5
        /// </summary>
        [Symbol("Sreg", SM.Sreg)]
        Sreg,

        /// <summary>
        /// <see cref='SM.moffs8'/>
        /// </summary>
        [Symbol("moffs8", SM.moffs8)]
        Moffs8,

        /// <summary>
        /// <see cref='SM.moffs16'/>
        /// </summary>
        [Symbol("moffs16", SM.moffs16)]
        Moffs16,

        /// <summary>
        /// <see cref='SM.moffs32'/>
        /// </summary>
        [Symbol("moffs32", SM.moffs32)]
        Moffs32,

        /// <summary>
        /// <see cref='SM.moffs64'/>
        /// </summary>
        [Symbol("moffs64", SM.moffs64)]
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
    }
}