//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum TypeWidthKind : ushort
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
    }
}