//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using W = DataWidth;

    /// <summary>
    /// Root source for width-related kinds throughout the system
    /// </summary>
    [Flags]
    public enum CellWidth : uint
    {
        /// <summary>
        /// Indicates a synthetic, but useful, bit-width of 1
        /// </summary>
        W1 = W.W1,

        /// <summary>
        /// Indicates a bit-width of 8
        /// </summary>
        W8 = W.W8,

        /// <summary>
        /// Indicates a bit-width of 16
        /// </summary>
        W16 = W.W16,

        /// <summary>
        /// Indicates a bit-width of 32
        /// </summary>
        W32 = W.W32,

        /// <summary>
        /// Indicates a bit-width of 64
        /// </summary>
        W64 = W.W64,

        /// <summary>
        /// The widths of primal numeric cells 
        /// </summary>
        Numeric =  W8 | W16 | W32 | W64,    
    }
}