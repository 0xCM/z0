//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmSigDocs;

    public enum RelToken : byte
    {
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
    }
}