//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmSigDocs;

    [SymbolSource]
    public enum AsmSigToken : byte
    {
        None = 0,

        [Symbol("al")]
        al,

        [Symbol("ax")]
        ax,

        [Symbol("eax")]
        eax,

        [Symbol("rax")]
        rax,

        /// <summary>
        /// <see cref='SD.bnd'/>
        /// </summary>
        [Symbol("bnd", SD.bnd)]
        bnd,

        /// <summary>
        /// <see cref='SD.imm8'/>
        /// </summary>
        [Symbol("imm8", SD.imm8)]
        imm8,

        /// <summary>
        /// <see cref='SD.imm16'/>
        /// </summary>
        [Symbol("imm16", SD.imm16)]
        imm16,

        /// <summary>
        /// <see cref='SD.imm32'/>
        /// </summary>
        [Symbol("imm32", SD.imm32)]
        imm32,

        /// <summary>
        /// <see cref='SD.imm64'/>
        /// </summary>
        [Symbol("imm64", SD.imm64)]
        imm64,

        /// <summary>
        /// <see cref='SD.r8'/>
        /// </summary>
        [Symbol("r8", SD.r8)]
        r8,

        /// <summary>
        /// <see cref='SD.r16'/>
        /// </summary>
        [Symbol("r16", SD.r16)]
        r16,

        /// <summary>
        /// <see cref='SD.r32'/>
        /// </summary>
        [Symbol("r32", SD.r32)]
        r32,

        /// <summary>
        /// <see cref='SD.r32a'/>
        /// </summary>
        [Symbol("r32a", SD.r32a)]
        r32a,

        /// <summary>
        /// <see cref='SD.r32b'/>
        /// </summary>
        [Symbol("r32b", SD.r32b)]
        r32b,

        /// <summary>
        /// <see cref='SD.r64'/>
        /// </summary>
        [Symbol("r64", SD.r64)]
        r64,

        /// <summary>
        /// <see cref='SD.rm8'/>
        /// </summary>
        [Symbol("r/m8", SD.rm8)]
        rm8,

        /// <summary>
        /// <see cref='SD.rm16'/>
        /// </summary>
        [Symbol("r/m16", SD.rm16)]
        rm16,

        /// <summary>
        /// <see cref='SD.rm32'/>
        /// </summary>
        [Symbol("r/m32", SD.rm32)]
        rm32,

        /// <summary>
        /// <see cref='SD.rm64'/>
        /// </summary>
        [Symbol("r/m64", SD.rm64)]
        rm64,

        [Symbol("reg/m8")]
        regM8,

        [Symbol("reg/m16")]
        regM16,

        [Symbol("reg/m32")]
        regM32,

        [Symbol("reg")]
        reg,

        /// <summary>
        /// <see cref='SD.m'/>
        /// </summary>
        [Symbol("m", SD.m)]
        m,

        [Symbol("mem")]
        mem,

        /// <summary>
        /// <see cref='SD.m8'/>
        /// </summary>
        [Symbol("m8", SD.m8)]
        m8,

        /// <summary>
        /// A 16-bit operand in memory pointed to by a register, and applicable only to string instructions
        /// </summary>
        [Symbol("m16", SD.m16)]
        m16,

        /// <summary>
        /// A 32-bit operand in memory pointed to by a register, and applicable only to string instructions
        /// </summary>
        [Symbol("m32", SD.m32)]
        m32,

        /// <summary>
        /// <see cref='SD.m64'/>
        /// </summary>
        [Symbol("m64", SD.m64)]
        m64,

        /// <summary>
        /// A 128-bit operand in memory
        /// </summary>
        [Symbol("m128", SD.m128)]
        m128,

        /// <summary>
        /// A 256-bit operand in memory
        /// </summary>
        [Symbol("m256", SD.m256)]
        m256,

        /// <summary>
        /// <see cref='SD.m16int'/>
        /// </summary>
        [Symbol("m16int", SD.m16int)]
        m16Int,

        /// <summary>
        /// <see cref='SD.m32int'/>
        /// </summary>
        [Symbol("m32int", SD.m32int)]
        m32Int,

        /// <summary>
        /// <see cref='SD.m64int'/>
        /// </summary>
        [Symbol("m64int", SD.m64int)]
        m64Int,

        /// <summary>
        /// <see cref='SD.mm'/>
        /// </summary>
        [Symbol("mm", SD.mm)]
        mm,

        /// <summary>
        /// <see cref='SD.xmm'/>
        /// </summary>
        [Symbol("xmm", SD.xmm)]
        xmm,

        /// <summary>
        /// <see cref='SD.xmm1'/>
        /// </summary>
        [Symbol("xmm1", SD.xmm1)]
        xmm1,

        /// <summary>
        /// <see cref='SD.xmm2'/>
        /// </summary>
        [Symbol("xmm2", SD.xmm2)]
        xmm2,

        /// <summary>
        /// <see cref='SD.xmm3'/>
        /// </summary>
        [Symbol("xmm3", SD.xmm3)]
        xmm3,

        /// <summary>
        /// <see cref='SD.xmm32'/>
        /// </summary>
        [Symbol("xmm32", SD.xmm32)]
        xmm32,

        /// <summary>
        /// <see cref='SD.xmm64'/>
        /// </summary>
        [Symbol("xmm64", SD.xmm64)]
        xmm64,

        /// <summary>
        /// <see cref='SD.xmm128'/>
        /// </summary>
        [Symbol("xmm128", SD.xmm128)]
        xmm128,

        /// <summary>
        /// <see cref='SD.ymm'/>
        /// </summary>
        [Symbol("ymm", SD.ymm)]
        ymm,

        /// <summary>
        /// <see cref='SD.ymm1'/>
        /// </summary>
        [Symbol("ymm1", SD.ymm1)]
        ymm1,

        /// <summary>
        /// <see cref='SD.ymm2'/>
        /// </summary>
        [Symbol("ymm2", SD.ymm2)]
        ymm2,

        /// <summary>
        /// <see cref='SD.ymm3'/>
        /// </summary>
        [Symbol("ymm3", SD.ymm3)]
        ymm3,

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
        /// <see cref='SD.rel8'/>
        /// </summary>
        [Symbol("rel8", SD.rel8)]
        rel8,

        /// <summary>
        /// <see cref='SD.rel16'/>
        /// </summary>
        [Symbol("rel16", SD.rel16)]
        rel16,

        /// <summary>
        /// <see cref='SD.rel32'/>
        /// </summary>
        [Symbol("rel32", SD.rel32)]
        rel32,

        /// <summary>
        /// A segment register, where the register bit assignments are ES = 0, CS = 1, SS = 2, DS = 3, FS = 4, and GS = 5
        /// </summary>
        [Symbol("Sreg", SD.Sreg)]
        Sreg,

        /// <summary>
        /// <see cref='SD.moffs8'/>
        /// </summary>
        [Symbol("moffs8", SD.moffs8)]
        moffs8,

        /// <summary>
        /// <see cref='SD.moffs16'/>
        /// </summary>
        [Symbol("moffs16", SD.moffs16)]
        moffs16,

        /// <summary>
        /// <see cref='SD.moffs32'/>
        /// </summary>
        [Symbol("moffs32", SD.moffs32)]
        moffs32,

        /// <summary>
        /// <see cref='SD.moffs64'/>
        /// </summary>
        [Symbol("moffs64", SD.moffs64)]
        moffs64,

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

        /// <summary>
        /// A mask register used as a regular operand (either destination or source). The 64-bit k registers are: k0 through k7
        /// </summary>
        [Symbol("k1", SD.k1)]
        k1,
    }
}