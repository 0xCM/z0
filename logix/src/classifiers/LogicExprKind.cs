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
    /// Classifier for logical expressions
    /// </summary>
    public enum LogicExprKind : uint
    {        
        /// <summary>
        /// Classifies boolean bariables
        /// </summary>
        Variable = Pow2.T01,

        /// <summary>
        /// Classifies a boolean expression that depends on one or more variables
        /// </summary>
        Varied = Pow2.T02,

        /// <summary>
        /// Classifies a boolean literal expression
        /// </summary>
        Literal = Pow2.T03,

        /// <summary>
        /// Classifies a boolean equality expression
        /// </summary>
        Equality = Pow2.T04,

        /// <summary>
        /// Classifies a boolean unary operator
        /// </summary>
        UnaryOperator = Pow2.T05,

        /// <summary>
        /// Classifies a boolean binary operator
        /// </summary>
        BinaryOperator = Pow2.T06,

        /// <summary>
        /// Classifies a boolean ternary operator
        /// </summary>
        TernaryOperator = Pow2.T07,

    }



}