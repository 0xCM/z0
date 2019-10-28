//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    
    using static zfunc;

    /// <summary>
    /// Classsifies (supported) arithmetic operators
    /// </summary>
    public enum BinaryArithmeticOpKind : uint
    {

        /// <summary>
        /// Classifies a binary operator that returns true iff its operands are equal
        /// </summary>
        Eq = ComparisonKind.Eq,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is strictly smaller than the left operand
        /// </summary>
        Lt = ComparisonKind.Lt,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is smaller than or equal to the left operand
        /// </summary>
        LtEq = ComparisonKind.LtEq,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is strictly greater than the left operand
        /// </summary>
        Gt  = ComparisonKind.Gt,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is greater than or equal to the left operand
        /// </summary>
        GtEq = ComparisonKind.GtEq,
        
        /// <summary>
        /// Classifies a binary operator that returns true iff its operands are not equal
        /// </summary>
        Neq = ComparisonKind.Neq,

        Add = Pow2.T10,

        Sub = Pow2.T11,

    }

}