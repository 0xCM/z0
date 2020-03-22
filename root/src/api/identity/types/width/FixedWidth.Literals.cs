//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines fixed bit-width classifiers/identifiers
    /// </summary>
    public enum FixedWidth : ushort
    {
        /// <summary>
        /// Indicates the width is not fixed or is unknown
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates a bit-width of 1
        /// </summary>
        W1 = 1,

        /// <summary>
        /// Indicates a bit-width of 2
        /// </summary>
        W2 = 2,

        /// <summary>
        /// Indicates a bit-width of 4
        /// </summary>
        W4 = 4,

        /// <summary>
        /// Indicates a bit-width of 8
        /// </summary>
        W8 = 8,

        /// <summary>
        /// Indicates a bit-width of 16
        /// </summary>
        W16 = 16,

        /// <summary>
        /// Indicates a bit-width of 32
        /// </summary>
        W32 = 32,

        /// <summary>
        /// Indicates a bit-width of 64
        /// </summary>
        W64 = 64,

        /// <summary>
        /// Indicates a bit-width of 128
        /// </summary>
        W128 = 128,

        /// <summary>
        /// Indicates a bit-width of 256
        /// </summary>
        W256 = 256,

        /// <summary>
        /// Indicates a bit-width of 512
        /// </summary>
        W512 = 512,

        /// <summary>
        /// Indicates a bit-width of 1024
        /// </summary>
        W1024 = 1024,

        NumericWidths = W8 | W16 | W32 | W64,
    }
}