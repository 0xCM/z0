//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Defines argument position indicators for up to 7 arguments
    /// </summary>
    [Flags]
    public enum ArgPosIndicator : byte
    {
        /// <summary>
        /// The position indicator for the first argument
        /// </summary>
        Pos0 = 2,

        /// <summary>
        /// The position indicator for a second argument
        /// </summary>
        Pos1 = 4,

        /// <summary>
        /// The position indicator for a third argument
        /// </summary>
        Pos2 = 8,

        /// <summary>
        /// The position indicator for a fourth argument
        /// </summary>
        Pos3 = 16,

        /// <summary>
        /// The position indicator for a fifth argument
        /// </summary>
        Pos4 = 32,

        /// <summary>
        /// The position indicator for a sixth argument
        /// </summary>
        Pos5 = 64,

        /// <summary>
        /// The position indicator for a seventh argument
        /// </summary>
        Pos6 = 128,
    }
}
