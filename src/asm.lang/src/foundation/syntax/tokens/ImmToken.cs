//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmSigDocs;

    [SymbolSource]
    public enum ImmToken : byte
    {
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
    }
}
