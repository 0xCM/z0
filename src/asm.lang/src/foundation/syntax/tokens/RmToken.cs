//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmSigDocs;
    using OCD = AsmOpCodeDocs;


    [SymbolSource]
    public enum RmToken : byte
    {
        /// <summary>
        /// <see cref='OCD.r'/>
        /// </summary>
        [Symbol("/r", OCD.r)]
        r,

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
    }
}