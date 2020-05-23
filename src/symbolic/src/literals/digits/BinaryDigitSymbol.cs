//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines the symbols that represent the base-2 digits
    /// </summary>
    public enum BinaryDigitSymbol : ushort
    {
        /// <summary>
        /// The symbolic void
        /// </summary>
        None = 0,

        /// <summary>
        /// Specifies 0 base 2, asci code 48
        /// </summary>
        b0 = '0',
        
        /// <summary>
        /// Specifies 1 base 2, asci code 49
        /// </summary>
        b1 = '1',

        /// <summary>
        /// The first declared symbol
        /// </summary>
        First = b0,

        /// <summary>
        /// The last declared symbol
        /// </summary>
        Last = b1,

        /// <summary>
        /// The symbol declaration count
        /// </summary>
        Count = Last - First + 1
    }
}