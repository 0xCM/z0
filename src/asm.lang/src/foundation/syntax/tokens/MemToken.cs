//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmSigDocs;

    [SymbolSource]
    public enum MemToken : byte
    {
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

    }
}