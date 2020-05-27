//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines common numeric bases
    /// </summary>
    public enum NumericBaseKind : uint
    {
        None = 0,
        
        /// <summary>
        /// Identifies base 2, binary
        /// </summary>
        B = 2,

        /// <summary>
        /// Identifies base 3, ternary
        /// </summary>
        T = 3,

        /// <summary>
        /// Identifies base 8, octal
        /// </summary>
        O = 8,

        /// <summary>
        /// Identifies base 10, decimal
        /// </summary>
        D = 10,

        /// <summary>
        /// Identifies base 16, hex
        /// </summary>
        X = 16,
    }
}