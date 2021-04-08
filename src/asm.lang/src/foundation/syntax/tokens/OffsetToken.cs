//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmOpCodeDocs;

    [SymbolSource]
    public enum OffsetToken : byte
    {
        /// <summary>
        /// <see cref='SD.cb'/>
        /// </summary>
        [Symbol("cb", SD.cb)]
        cb,

        /// <summary>
        /// <see cref='SD.cw'/>
        /// </summary>
        [Symbol("cw", SD.cw)]
        cw,

        /// <summary>
        /// <see cref='SD.cd'/>
        /// </summary>
        [Symbol("cd", SD.cd)]
        cd,

        /// <summary>
        /// <see cref='SD.cp'/>
        /// </summary>
        [Symbol("cp", SD.cp)]
        cp,

        /// <summary>
        /// <see cref='SD.co'/>
        /// </summary>
        [Symbol("co", SD.co)]
        co,

        /// <summary>
        /// <see cref='SD.ct'/>
        /// </summary>
        [Symbol("ct", SD.ct)]
        ct,
    }
}