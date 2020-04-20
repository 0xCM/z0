//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using OC = OperationClass;
    
    /// <summary>
    /// Classifies operators of arity up to 3
    /// </summary>
    [Flags]
    public enum OperatorClass : ushort
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        Emitter = OC.Emitter,

        /// <summary>
        /// Classifies functions for which operands and return type are homogenous
        /// </summary>        
        Operator = OC.Operator,

        /// <summary>
        /// Classifies operators that accept one argument
        /// </summary>        
        UnaryOp = OC.UnaryOp,

        /// <summary>
        /// Classifies operators that accept two arguments
        /// </summary>        
        BinaryOp = OC.BinaryOp,
        
        /// <summary>
        /// Classifies operators that accept three arguments
        /// </summary>        
        TernaryOp = OC.TernaryOp,
    }     
}