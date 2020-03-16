//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using OC = OperationClass;

    /// <summary>
    /// Classifies operators of arity either 1, 2, or 3
    /// </summary>
    [Flags]
    public enum OperatorClass : ulong
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies functions for which operands and return type are homogenous
        /// </summary>        
        Operator = OC.Operator,

        /// <summary>
        /// Classifies operators that accept one argument
        /// </summary>        
        UnaryOperator = OC.UnaryOperator,

        /// <summary>
        /// Classifies operators that accept two arguments
        /// </summary>        
        BinaryOperator = OC.BinaryOperator,
        
        /// <summary>
        /// Classifies operators that accept three arguments
        /// </summary>        
        TernaryOperator = OC.TernaryOperator,
    }
}