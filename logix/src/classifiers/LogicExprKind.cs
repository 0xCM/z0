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

    public enum LogicExprKind : uint
    {        
        /// <summary>
        /// Identifies the boolean variable classification
        /// </summary>
        Variable = Pow2.T01,

        /// <summary>
        /// Identifies a boolean expression that depends on one or more variables
        /// </summary>
        Varied = Pow2.T02,

        /// <summary>
        /// Identifies the boolean literal classification
        /// </summary>
        Literal = Pow2.T03,

        /// <summary>
        /// Identifies the equality operator classification
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

    }



}