//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmSyntaxDocs;
    using OCT = AsmOpCodeToken;

    [SymbolSource]
    public enum AsmOffsetToken : byte
    {
        /// <summary>
        /// <see cref='SD.cb'/>
        /// </summary>
        [Symbol("cb", SD.cb)]
        cb = OCT.cb,

        /// <summary>
        /// <see cref='SD.cw'/>
        /// </summary>
        [Symbol("cw", SD.cw)]
        cw = OCT.cw,

        /// <summary>
        /// <see cref='SD.cd'/>
        /// </summary>
        [Symbol("cd", SD.cd)]
        cd = OCT.cd,

        /// <summary>
        /// <see cref='SD.cp'/>
        /// </summary>
        [Symbol("cp", SD.cp)]
        cp = OCT.cp,

        /// <summary>
        /// <see cref='SD.co'/>
        /// </summary>
        [Symbol("co", SD.co)]
        co = OCT.co,

        /// <summary>
        /// <see cref='SD.ct'/>
        /// </summary>
        [Symbol("ct", SD.ct)]
        ct = OCT.ct,
    }
}