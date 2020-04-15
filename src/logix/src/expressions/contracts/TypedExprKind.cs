//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    /// <summary>
    /// Classifies typed expressions
    /// </summary>
    public enum TypedExprKind : byte
    {        
        /// <summary>
        /// Classifies a variable
        /// </summary>
        Variable = LogicExprKind.Variable,

        /// <summary>
        /// Classifies an expression that depends on one or more variables
        /// </summary>
        Varied = LogicExprKind.Varied,

        /// <summary>
        /// Classifies a literal expression
        /// </summary>
        Literal = LogicExprKind.Literal,

        /// <summary>
        /// Classifies a comparison expression
        /// </summary>
        Comparison = LogicExprKind.Comparison,

        /// <summary>
        /// Classifies a unary operator
        /// </summary>
        UnaryOperator = LogicExprKind.UnaryOperator,

        /// <summary>
        /// Classifies a binary operator
        /// </summary>
        BinaryOperator = LogicExprKind.BinaryOperator,

        /// <summary>
        /// Classifies a ternary operator
        /// </summary>
        TernaryOperator = LogicExprKind.TernaryOperator,
        
        /// <summary>
        /// Classifies a shift expression
        /// </summary>
        ShiftExpr = 17,
    }
}