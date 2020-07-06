//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using W = DataWidth;

    /// <summary>
    /// Defines a <see cref="DataWidth"/> subset that is constrained to widths of numeric primitives
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
        W1 = (byte)W.W1,

        /// <summary>
        /// Indicates a bit-width of 8
        /// </summary>
        W8 = (byte)W.W8,

        /// <summary>
        /// Indicates a bit-width of 16
        /// </summary>
        W16 = (byte)W.W16,

        /// <summary>
        /// Indicates a bit-width of 32
        /// </summary>
        W32 = (byte)W.W32,

        /// <summary>
        /// Indicates a bit-width of 64
        /// </summary>
        W64 = (byte)W.W64,
    }
}