//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines literals that correspond to base-10 digits
    /// </summary>
    public enum DecimalDigit : byte
    {
        /// <summary>
        /// Specifies 0 base 10
        /// </summary>
        d0 = 0,

        /// <summary>
        /// Specifies 1 base 10
        /// </summary>
        d1 = 1,
        
        /// <summary>
        /// Specifies 2 base 10
        /// </summary>
        d2 = 2,
        
        /// <summary>
        /// Specifies 3 base 10
        /// </summary>
        d3 = 3,

        /// <summary>
        /// Specifies 4 base 10
        /// </summary>
        d4 = 4,

        /// <summary>
        /// Specifies 5 base 10
        /// </summary>
        d5 = 5,

        /// <summary>
        /// Specifies 6 base 10
        /// </summary>
        d6 = 6,

        /// <summary>
        /// Specifies 7 base 10
        /// </summary>
        d7 = 7,
        
        /// <summary>
        /// Specifies 8 base 10
        /// </summary>
        d8 = 8,
        
        /// <summary>
        /// Specifies 9 base 10
        /// </summary>
        d9 = 9,        

        /// <summary>
        /// The first declared digit
        /// </summary>
        First = d0,

        /// <summary>
        /// The last declared digit
        /// </summary>
        Last = d9,

        /// <summary>
        /// The digit declaration count
        /// </summary>
        Count = Last - First + 1
    }
}