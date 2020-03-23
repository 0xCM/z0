//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using TW = TypeWidth;

    /// <summary>
    /// Defines a <see cref="FixedWidth"/> subset that is constrained to widths of numeric primitives
    /// </summary>
    public enum NumericWidth : ushort
    {
        /// <summary>
        /// Indicates a synthetic, but useful, bit-width of 1
        /// </summary>
        W1 = TW.W1,

        /// <summary>
        /// Indicates a bit-width of 8
        /// </summary>
        W8 = TW.W8,

        /// <summary>
        /// Indicates a bit-width of 16
        /// </summary>
        W16 = TW.W16,

        /// <summary>
        /// Indicates a bit-width of 32
        /// </summary>
        W32 = TW.W32,

        /// <summary>
        /// Indicates a bit-width of 64
        /// </summary>
        W64 = TW.W64,
    }
}
