//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines literals that correspond to base-2 digits
    /// </summary>
    public enum BinaryDigit : byte
    {
        /// <summary>
        /// Specifies 0 base 2
        /// </summary>
        b0 = 0,
        
        /// <summary>
        /// Specifies 1 base 2
        /// </summary>
        b1 = 1,

        /// <summary>
        /// The first declared digit
        /// </summary>
        First = b0,

        /// <summary>
        /// The last declared digit
        /// </summary>
        Last = b1,

        /// <summary>
        /// The digit declaration count
        /// </summary>
        Count = Last - First + 1         
    }
}