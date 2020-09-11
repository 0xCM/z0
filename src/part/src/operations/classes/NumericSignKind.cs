//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines an equivalence class over values of numeric kind
    /// </summary>
    public enum NumericSignKind : sbyte
    {
        /// <summary>
        /// Indicates a value is less than zero
        /// </summary>
        Negative = -1,

        /// <summary>
        /// Indicates that a value has no sign, applicable only to zero, or that the sign is unspecified/unknown
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates that a value is greater than zero
        /// </summary>
        Positive = 1,
    }
}