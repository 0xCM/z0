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
        Variable = LogicExprKind.Variable,

        /// <summary>
        /// Identifies expression that depends on one or more variables
        /// </summary>
        Varied = LogicExprKind.Varied,

        /// <summary>
        /// Identifies a literal expression
        /// </summary>
        Literal = LogicExprKind.Literal,

        /// <summary>
        /// Classifies an identity
        /// </summary>
        Equality = LogicExprKind.Equality,

        /// <summary>
        /// Identifies the unary operator classification
        /// </summary>
        UnaryOperator = LogicExprKind.UnaryOperator,

        /// <summary>
        /// Identifies the binary operator classification
        /// </summary>
        BinaryOperator = LogicExprKind.BinaryOperator,

        /// <summary>
        /// Identifies the ternary operator classification
        /// </summary>
        TernaryOperator = LogicExprKind.TernaryOperator,

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