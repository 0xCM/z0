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

    /// <summary>
    /// Classifies typed expressions
    /// </summary>
    public enum TypedExprKind : uint
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
        /// Classifies an identity
        /// </summary>
        Equality = LogicExprKind.Equality,

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
        /// Classifies a comparision (operator?)
        /// </summary>
        Comparison = Pow2.T13,

        /// <summary>
        /// Classifies a shift expression
        /// </summary>
        ShiftExpr = Pow2.T14,
    }



}