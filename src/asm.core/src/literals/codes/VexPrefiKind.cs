//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Classfies vex prefix codes
    /// </summary>
    public enum VexPrefiKind : byte
    {
        None = 0,

        /// <summary>
        /// The leading byte of a 2-byte vex prefix sequence
        /// </summary>
        xC5 = 0xc5,

        /// <summary>
        /// The leading byte of a 3-byte vex prefix sequence
        /// </summary>
        xC4 = 0xc4,
    }
}