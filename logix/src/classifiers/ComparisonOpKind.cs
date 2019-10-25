//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;

    /// <summary>
    /// Classifies binary boolean comparison operators
    /// </summary>
    public enum ComparisonOpKind : byte
    {        
        /// <summary>
        /// Classifies a binary operator that returns true iff its operands are equal
        /// </summary>
        Eq = Pow2.T00,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is strictly smaller than the left operand
        /// </summary>
        Lt = Pow2.T01,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is smaller than or equal to the left operand
        /// </summary>
        LtEq = Pow2.T02,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is strictly greater than the left operand
        /// </summary>
        Gt = Pow2.T03,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is greater than or equal to the left operand
        /// </summary>
        GtEq = Pow2.T04
    }
}


