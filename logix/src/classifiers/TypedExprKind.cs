//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public enum TypedExprKind : uint
    {
        
        /// <summary>
        /// Specifies a variable classification
        /// </summary>
        Variable = Pow2.T01,

        /// <summary>
        /// Identifies expression that depends on one or more variables
        /// </summary>
        Varied = Pow2.T02,

        /// <summary>
        /// Identifies a literal expression
        /// </summary>
        Literal = Pow2.T03,

        /// <summary>
        /// Classifies an identity
        /// </summary>
        Equality = Pow2.T07,

        /// <summary>
        /// Identifies the unary operator classification
        /// </summary>
        UnaryOperator = Pow2.T10,

        /// <summary>
        /// Identifies the binary operator classification
        /// </summary>
        BinaryOperator = Pow2.T11,

        /// <summary>
        /// Identifies the ternary operator classification
        /// </summary>
        TernaryOperator = Pow2.T12,

        /// <summary>
        /// Classifies a comparision
        /// </summary>
        Comparison = Pow2.T13,

        /// <summary>
        /// Classifies a shift expression
        /// </summary>
        ShiftExpr = Pow2.T14,
    }



}