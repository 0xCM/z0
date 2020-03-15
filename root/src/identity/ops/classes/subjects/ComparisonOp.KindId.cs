//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static OpKindId;

    using A = OpKindAttribute;
    using Id = OpKindId;

    /// <summary>
    /// Identifies comparison operator classes
    /// </summary>
    public enum ComparisonOpKindId : ulong
    {        
        /// <summary>
        /// Classifies a binary operator that returns true iff its operands are equal
        /// </summary>
        Eq = Id.Eq,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is strictly smaller than the left operand
        /// </summary>
        Lt = Id.Lt,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is smaller than or equal to the left operand
        /// </summary>
        LtEq = Id.LtEq,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is strictly greater than the left operand
        /// </summary>
        Gt  = Id.Gt,

        /// <summary>
        /// Classifies a binary operator that returns true if the left operand is greater than or equal to the left operand
        /// </summary>
        GtEq = Id.GtEq,
        
        /// <summary>
        /// Classifies a binary operator that returns true iff its operands are not equal
        /// </summary>
        Neq = Id.Neq,
    }    
}