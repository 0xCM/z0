//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmSigDocs;

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

        /// <summary>
        /// <see cref='SD.bnd'/>
        /// </summary>
        [Symbol("bnd", SD.bnd)]
        bnd,

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
        /// A segment register, where the register bit assignments are ES = 0, CS = 1, SS = 2, DS = 3, FS = 4, and GS = 5
        /// </summary>
        [Symbol("Sreg", SD.Sreg)]
        Sreg,

        /// <summary>
        /// A mask register used as a regular operand (either destination or source). The 64-bit k registers are: k0 through k7
        /// </summary>
        [Symbol("k1", SD.k1)]
        k1,
    }
}