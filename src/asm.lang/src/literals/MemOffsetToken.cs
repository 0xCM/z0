//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmSigDocs;

    [SymbolSource]
    public enum MemOffsetToken : byte
    {
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
    }
}