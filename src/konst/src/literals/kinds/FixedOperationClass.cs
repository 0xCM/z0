//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using OC = OperationClass;

    [Flags]
    public enum FixedOperationClass : ushort
    {
        /// <summary>
        /// The class that classifies nothing
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies fixed operations of arity 0
        /// </summary>        
        Nullary = OC.Nullary,

        /// <summary>
        /// Classifies fixed operations of arity 1
        /// </summary>        
        Unary = OC.Unary,

        /// <summary>
        /// Classifies fixed operations of arity 2
        /// </summary>        
        Binary = OC.Binary,

        /// <summary>
        /// Classifies fixed operations of arity 3
        /// </summary>        
        Ternary = OC.Ternary,   

        /// <summary>
        /// Classifies operations with void return
        /// </summary>        
        Action = OC.Action,

        /// <summary>
        /// Classifies operations as those with non-void return
        /// </summary>        
        Function = OC.Function,

        /// <summary>
        /// Classifies functions for which operands and return type are homogenous
        /// </summary>        
        Operator = OC.Operator,

        /// <summary>
        /// Classifies functions that return a system boolean value or a bit value
        /// </summary>        
        Predicate = OC.Predicate,

        /// <summary>
        /// Identifies the fixed classifier lower bound
        /// </summary>        
        FixedClass = OC.LastClass << 1,

        /// <summary>
        /// Specifies the last classifer
        /// </summary>        
        LastClass = FixedClass,

        /// <summary>
        /// Classifies fixed actions
        /// </summary>        
        FixedAction = FixedClass | Action,

        /// <summary>
        /// Classifies fixed functions
        FixedFunction = FixedClass | Function,

        /// <summary>
        /// Classifies fixed operators
        /// </summary>        
        FixedOperator = FixedClass | Operator,

        /// <summary>
        /// Classifies fixed predicates
        /// </summary>        
        FixedPredicate = FixedClass | Predicate,        
    }
}