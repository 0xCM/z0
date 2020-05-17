//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines common numeric formatting options
    /// </summary>
    [Flags]
    public enum NumericFormatStyle
    {        
        None = 0,

        /// <summary>
        /// Indicates that a numeric indicator, if any, leads the numeric content, such as 0xF3 or 0b001
        /// </summary>
        PrefixIndicator = 1,

        /// <summary>
        /// Indicates that a numeric indicator, if any, follows the numeric content, such as F3h or 001b
        /// </summary>
        PostfixIndicator = 2,
        
        /// <summary>
        /// Indicates that numeric content will be left-padded with zeroes until the numer of digits
        /// shown is the number of digits that appear in the maximum value for the type
        /// </summary>
        ZeroPad = 4,
        
        /// <summary>
        /// Indicates that a number can be block-partitioned into manageable pieces of even size, such as
        /// 001 010 111 or F1 28 C3
        /// </summary>
        Blocked = 8,
        
    }

}
