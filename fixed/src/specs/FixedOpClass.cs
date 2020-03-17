//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using ID = OperationClassId;

    [Flags]
    public enum FixedOpClass : ushort
    {
        /// <summary>
        /// The class that classifies nothing
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies fixed operations of arity 0
        /// </summary>        
        Nullary = ID.Nullary,

        /// <summary>
        /// Classifies fixed operations of arity 1
        /// </summary>        
        Unary = ID.Unary,

        /// <summary>
        /// Classifies fixed operations of arity 2
        /// </summary>        
        Binary = ID.Binary,

        /// <summary>
        /// Classifies fixed operations of arity 3
        /// </summary>        
        Ternary = ID.Ternary,   

        /// <summary>
        /// Classifies operations with void return
        /// </summary>        
        BaseAction = ID.Action,

        /// <summary>
        /// Classifies operations as those with non-void return
        /// </summary>        
        BaseFunction = ID.Function,

        /// <summary>
        /// Classifies functions for which operands and return type are homogenous
        /// </summary>        
        BaseOperator = ID.Operator,

        /// <summary>
        /// Classifies functions that return a system boolean value or a bit value
        /// </summary>        
        BasePredicate = ID.Predicate,

        /// <summary>
        /// Identifies the fixed classifier lower bound
        /// </summary>        
        FixedBase = ID.LastIdentity << 1,

        /// <summary>
        /// Classifies fixed actions
        /// </summary>        
        FixedAction = FixedBase | BaseAction,

        /// <summary>
        /// Classifies fixed functions
        FixedFunction = FixedBase | BaseFunction,

        /// <summary>
        /// Classifies fixed operators
        /// </summary>        
        FixedOperator = FixedBase | BaseOperator,

        /// <summary>
        /// Classifies fixed predicates
        /// </summary>        
        FixedPredicate = FixedBase | BasePredicate,
        
        /// <summary>
        /// Specifies the lower bound for fixed classifiers
        /// </summary>        
        FirstClass = FixedBase,
        
        /// <summary>
        /// Specifies the upper bound for fixed classifiers
        /// </summary>        
        LastClass = 2048    
    }
}