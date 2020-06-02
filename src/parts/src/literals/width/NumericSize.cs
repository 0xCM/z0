//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines a <see cref="TypeWidth"/> subset that is constrained to widths of numeric primitives
    /// and where width is expressed in bytes, not bits
    /// </summary>
    public enum NumericSize : byte
    {
        /// <summary>
        /// A width without substance
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates a width of 1 byte
        /// </summary>
        SZ1 = 1,

        /// <summary>
        /// Indicates a widths of 2 bytes
        /// </summary>
        SZ2 = 2,

        /// <summary>
        /// Indicates a width of 4 bytes
        /// </summary>
        SZ4 = 4,

        /// <summary>
        /// Indicates a width of 8 bytes
        /// </summary>
        SZ8 = 8,
    }

    partial class XTend
    {
        public static string Format(this NumericSize src)
            => ((byte)src).ToString();
    }
}