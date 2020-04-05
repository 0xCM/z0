//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Classifes an operation in various ways
    /// </summary>
    [Flags]
    public enum OperationClass : ushort
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies operations of arity 0
        /// </summary>        
        Nullary = 1,

        /// <summary>
        /// Classifies operations of arity 1
        /// </summary>        
        Unary = 2,

        /// <summary>
        /// Classifies operations of arity 2
        /// </summary>        
        Binary = 4,

        /// <summary>
        /// Classifies operations of arity 3
        /// </summary>        
        Ternary = 8,   

        /// <summary>
        /// Classifies operations with void return
        /// </summary>        
        Action = 16,

        /// <summary>
        /// Classifies operations as those with non-void return
        /// </summary>        
        Function = 32,

        /// <summary>
        /// Classifies functions for which operands and return type are homogenous
        /// </summary>        
        Operator = 64,

        /// <summary>
        /// Classifies functions that return a system boolean value or a bit value
        /// </summary>        
        Predicate = 128,

        /// <summary>
        /// Classifies system-level operations
        /// </summary>        
        System = 256,

        /// <summary>
        /// The last pure classifier
        /// </summary>        
        LastClass = System,        

        /// <summary>
        /// Classifies actions that accept one argument
        /// </summary>        
        Receiver = Nullary | Action,

        /// <summary>
        /// Classifies actions that accept one argument
        /// </summary>
        UnaryAction = Unary | Action,

        /// <summary>
        /// Classifies actions that accept two arguments
        /// </summary>        
        BinaryAction = Binary | Action,

        /// <summary>
        /// Classifies actions that accept three arguments
        /// </summary>        
        TernaryAction = Ternary | Action,

        /// <summary>
        /// Classifies functions that accept no arguments
        /// </summary>        
        Emitter = Function | Nullary,

        /// <summary>
        /// Classifies functions that accept one argument
        /// </summary>        
        UnaryFunc = Unary | Function,

        /// <summary>
        /// Classifies functions that accept two arguments
        /// </summary>        
        BinaryFunc =  Binary | Function,

        /// <summary>
        /// Classifies functions that accept three arguments
        /// </summary>        
        TernaryFunc = Ternary | Function,
        
        /// <summary>
        /// Classifies operators that accept one argument
        /// </summary>        
        UnaryOp = Unary | Function | Operator,

        /// <summary>
        /// Classifies operators that accept two arguments
        /// </summary>        
        BinaryOp = Binary | Function | Operator,
        
        /// <summary>
        /// Classifies operators that accept three arguments
        /// </summary>        
        TernaryOp = Ternary | Function | Operator,

        /// <summary>
        /// Classifies an operation as a unary predicate
        /// </summary>        
        UnaryPredicate = Unary | Function | Predicate,

        /// <summary>
        /// Classifies an operation as a binary predicate
        /// </summary>        
        BinaryPredicate = Binary | Function | Predicate,

        /// <summary>
        /// Classifies an operation as a ternary predicate
        /// </summary>        
        TernaryPredicate = Ternary | Function | Predicate
    }


}