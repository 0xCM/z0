//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using TW = TypeWidth;
    
    /// <summary>
    /// Defines a <see cref="TypeWidth"/> subset that is constrained to widths that correspond to x86-supported widths
    /// </summary>
    public enum VectorWidth : ushort
    {
        /// <summary>
        /// Clasifies nothing
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates a bit-width of 128
        /// </summary>
        W128 = TW.W128,

        /// <summary>
        /// Indicates a bit-width of 256
        /// </summary>
        W256 = TW.W256,

        /// <summary>
        /// Indicates a bit-width of 512
        /// </summary>
        W512 = TW.W512,

    }
}
