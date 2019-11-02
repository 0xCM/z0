//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    
    using static zfunc;

    /// <summary>
    /// Classifies unary bitwise operators
    /// </summary>
    public enum UnaryBitwiseOpKind : byte
    {
        /// <summary>
        /// The unary operator that always returns false
        /// </summary>
        False = UnaryLogicOpKind.False,

        /// <summary>
        /// Logial NOT
        /// </summary>
        Not = UnaryLogicOpKind.Not,

        /// <summary>
        /// The identity operator
        /// </summary>
        Identity = UnaryLogicOpKind.Identity,

        /// <summary>
        /// The unary operator that always returns true
        /// </summary>
        True = UnaryLogicOpKind.True,

        /// <summary>
        /// Two's complement negation
        /// </summary>
        Negate = 17,

    }

}