//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines numeric arity values and is independent of the arity classifier/classification scheme
    /// </summary>
    public enum ArityValue : byte
    {       
        /// <summary>
        /// None
        /// </summary>
        Nullary = 0,

        /// <summary>
        /// One
        /// </summary>
        Unary = 1,

        /// <summary>
        /// Two
        /// </summary>
        Binary = 2,

        /// <summary>
        /// Three
        /// </summary>
        Ternary = 3,
    }
}