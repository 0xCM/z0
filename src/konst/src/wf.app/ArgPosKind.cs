//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Pow2x8;

    /// <summary>
    /// Defines argument position indicators for up to 7 arguments
    /// </summary>
    [Flags]
    public enum ArgPosKind : byte
    {
        /// <summary>
        /// Identifies the first position
        /// </summary>
        Pos0 = P2ᐞ00,

        /// <summary>
        /// Identifies the second position
        /// </summary>
        Pos1 = P2ᐞ01,

        /// <summary>
        /// Identifies the third position
        /// </summary>
        Pos2 = P2ᐞ02,

        /// <summary>
        /// Identifies the fourth position
        /// </summary>
        Pos3 = P2ᐞ03,

        /// <summary>
        /// Identifies the fifth position
        /// </summary>
        Pos4 = P2ᐞ04,

        /// <summary>
        /// Identifies the sixth position
        /// </summary>
        Pos5 = P2ᐞ05,

        /// <summary>
        /// Identifies the seventh position
        /// </summary>
        Pos6 = P2ᐞ06,
    }
}
