//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Classifies the precision with which time value should be interpreted
    /// </summary>
    public enum DateTimeAccuracy
    {
        /// <summary>
        /// Specifies date-level accuracy
        /// </summary>
        Date,

        /// <summary>
        /// Specifies hour-level accuracy
        /// </summary>
        Hour,
        
        /// <summary>
        /// Specifies minute-level accuracy
        /// </summary>
        Minute,

        /// <summary>
        /// Specifies second-level accuracy
        /// </summary>
        Second,

        /// <summary>
        /// Specifies millisecond-level accuracy
        /// </summary>
        Millisecond
    }

}