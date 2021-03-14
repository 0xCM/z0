//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmSyntaxDocs;

    /// <summary>
    /// Specifies a '/r' token where r = 0..7
    /// </summary>
    public enum RegDigitToken : byte
    {
        /// <summary>
        /// See <see cref='SD.rd0'/>
        /// </summary>
        [Symbol("/0", SD.rd0)]
        R0 = 0,

        /// <summary>
        /// See <see cref='SD.rd1'/>
        /// </summary>
        [Symbol("/1", SD.rd1)]
        R1 = 1,

        /// <summary>
        /// See <see cref='SD.rd2'/>
        /// </summary>
        [Symbol("/2", SD.rd2)]
        R2 = 2,

        /// <summary>
        /// See <see cref='SD.rd3'/>
        /// </summary>
        [Symbol("/3", SD.rd3)]
        R3 = 3,

        /// <summary>
        /// See <see cref='SD.rd4'/>
        /// </summary>
        [Symbol("/4", SD.rd4)]
        R4 = 4,

        /// <summary>
        /// See <see cref='SD.rd5'/>
        /// </summary>
        [Symbol("/5", SD.rd5)]
        R5 = 5,

        /// <summary>
        /// See <see cref='SD.rd6'/>
        /// </summary>
        [Symbol("/6", SD.rd6)]
        R6 = 6,

        /// <summary>
        /// See <see cref='SD.rd7'/>
        /// </summary>
        [Symbol("/7", SD.rd7)]
        R7 = 7
    }
}