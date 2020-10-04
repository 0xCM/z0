//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines polarity classifiers
    /// </summary>
    public enum SignKind : sbyte
    {
        /// <summary>
        /// Indicates a value is greater than or equal to zero
        /// </summary>
        Unsigned = 1,

        /// <summary>
        /// Indicates a value is less than zero
        /// </summary>
        Signed = -1,
    }
}