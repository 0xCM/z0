//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Id = ApiKeyId;

    /// <summary>
    /// Identifies binary comparison predicates
    /// </summary>
    public enum BinaryComparisonApiKey : ushort
    {
        /// <summary>
        /// The empty identity
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies a binary operator that returns true iff its operands are equal
        /// </summary>
        Eq = Id.Eq,

        Eqz = Id.Eqz,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is strictly smaller than the left operand
        /// </summary>
        Lt = Id.Lt,

        Ltz = Id.Ltz,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is smaller than or equal to the left operand
        /// </summary>
        LtEq = Id.LtEq,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is strictly greater than the left operand
        /// </summary>
        Gt  = Id.Gt,

        Gtz = Id.Gtz,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is greater than or equal to the left operand
        /// </summary>
        GtEq = Id.GtEq,

        /// <summary>
        /// Classifies a binary operator that returns true iff its operands are not equal
        /// </summary>
        Neq = Id.Neq,

        Max = Id.Max,

        Min = Id.Min,

        Divides  = Id.Divides,
    }
}