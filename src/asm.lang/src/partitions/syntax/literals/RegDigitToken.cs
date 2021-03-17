//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmSyntaxDocs;
    using OCT = AsmOpCodeToken;

    /// <summary>
    /// Specifies a '/r' token where r = 0..7
    /// </summary>
    public enum RegDigitToken : byte
    {
        /// <summary>
        /// See <see cref='SD.r0'/>
        /// </summary>
        [Symbol("/0", SD.r0)]
        r0 = OCT.r0,

        /// <summary>
        /// See <see cref='SD.r1'/>
        /// </summary>
        [Symbol("/1", SD.r1)]
        r1 = OCT.r1,

        /// <summary>
        /// See <see cref='SD.r2'/>
        /// </summary>
        [Symbol("/2", SD.r2)]
        r2 = OCT.r2,

        /// <summary>
        /// See <see cref='SD.r3'/>
        /// </summary>
        [Symbol("/3", SD.r3)]
        r3 = OCT.r3,

        /// <summary>
        /// See <see cref='SD.r4'/>
        /// </summary>
        [Symbol("/4", SD.r4)]
        r4 = OCT.r4,

        /// <summary>
        /// See <see cref='SD.r5'/>
        /// </summary>
        [Symbol("/5", SD.r5)]
        r5 = OCT.r5,

        /// <summary>
        /// See <see cref='SD.r6'/>
        /// </summary>
        [Symbol("/6", SD.r6)]
        r6 = OCT.r6,

        /// <summary>
        /// See <see cref='SD.r7'/>
        /// </summary>
        [Symbol("/7", SD.r7)]
        r7 = OCT.r7,
    }
}