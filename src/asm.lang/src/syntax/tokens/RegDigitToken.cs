//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using OCD = AsmOpCodeDocs;
    using OCT = AsmOpCodeToken;

    /// <summary>
    /// Specifies a '/r' token where r = 0..7
    /// </summary>
    [SymbolSource]
    public enum RegDigitToken : byte
    {
        /// <summary>
        /// See <see cref='OCD.r0'/>
        /// </summary>
        [Symbol("/0", OCD.r0)]
        r0 = OCT.r0,

        /// <summary>
        /// See <see cref='OCD.r1'/>
        /// </summary>
        [Symbol("/1", OCD.r1)]
        r1 = OCT.r1,

        /// <summary>
        /// See <see cref='OCD.r2'/>
        /// </summary>
        [Symbol("/2", OCD.r2)]
        r2 = OCT.r2,

        /// <summary>
        /// See <see cref='OCD.r3'/>
        /// </summary>
        [Symbol("/3", OCD.r3)]
        r3 = OCT.r3,

        /// <summary>
        /// See <see cref='OCD.r4'/>
        /// </summary>
        [Symbol("/4", OCD.r4)]
        r4 = OCT.r4,

        /// <summary>
        /// See <see cref='OCD.r5'/>
        /// </summary>
        [Symbol("/5", OCD.r5)]
        r5 = OCT.r5,

        /// <summary>
        /// See <see cref='OCD.r6'/>
        /// </summary>
        [Symbol("/6", OCD.r6)]
        r6 = OCT.r6,

        /// <summary>
        /// See <see cref='OCD.r7'/>
        /// </summary>
        [Symbol("/7", OCD.r7)]
        r7 = OCT.r7,
    }
}