//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using FW = FixedWidth;
    
    /// <summary>
    /// Defines a <see cref="FixedWidth"/> subset that is constrained to widths that correspond to x86-supported widths
    /// </summary>
    public enum VectorWidth : uint
    {
        /// <summary>
        /// Clasifies nothing
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates a bit-width of 128
        /// </summary>
        W128 = FW.W128,

        /// <summary>
        /// Indicates a bit-width of 256
        /// </summary>
        W256 = FW.W256,

        /// <summary>
        /// Indicates a bit-width of 512
        /// </summary>
        W512 = FW.W512,
    }
}
