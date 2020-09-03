//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static BitSeq2;

    /// <summary>
    /// Classifies unary logic operators
    /// </summary>
    public enum UnaryBitLogic : byte
    {
        None = 0,

        /// <summary>
        /// The unary operator that always returns false
        /// </summary>
        False = b00,

        /// <summary>
        /// Logical NOT
        /// </summary>
        Not = b01,

        /// <summary>
        /// The identity operator
        /// </summary>
        Identity = b10,

        /// <summary>
        /// The unary operator that always returns true
        /// </summary>
        True = b11,
    }
}