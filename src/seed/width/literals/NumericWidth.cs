//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using TW = TypeWidth;

    /// <summary>
    /// Defines a <see cref="TypeWidth"/> subset that is constrained to widths of numeric primitives
    /// </summary>
    public enum NumericWidth : byte
    {
        /// <summary>
        /// A width without substance
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates a synthetic, but useful, bit-width of 1
        /// </summary>
        W1 = (byte)TW.W1,

        /// <summary>
        /// Indicates a bit-width of 8
        /// </summary>
        W8 = (byte)TW.W8,

        /// <summary>
        /// Indicates a bit-width of 16
        /// </summary>
        W16 = (byte)TW.W16,

        /// <summary>
        /// Indicates a bit-width of 32
        /// </summary>
        W32 = (byte)TW.W32,

        /// <summary>
        /// Indicates a bit-width of 64
        /// </summary>
        W64 = (byte)TW.W64,
    }
}
