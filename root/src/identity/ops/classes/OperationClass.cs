//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Root;

    /// <summary>
    /// Classifes an operation in various ways
    /// </summary>
    [Flags]
    public enum OperationClass : ulong
    {
        None = 0,

        /// <summary>
        /// Classifies operations as those with void return
        /// </summary>        
        Action = 1,

        /// <summary>
        /// Classifies operations as those with non-void return
        /// </summary>        
        Function = 2,
        
        /// <summary>
        /// Classifies an operation that accepts no arguments
        /// </summary>        
        Nullary = 4,

        /// <summary>
        /// Classifies an operation that accepts 1 argument
        /// </summary>        
        Unary = 8,

        /// <summary>
        /// Classifies an operation that accepts 2 arguments
        /// </summary>        
        Binary = 16,

        /// <summary>
        /// Classifies an operation that accepts 3 arguments
        /// </summary>        
        Ternary = 32,

        /// <summary>
        /// Classifies functions for which operands, totgeher with the return type, are homogenous
        /// </summary>        
        Operator = 64,

        
        /// <summary>
        /// Classifies functions that adjudicate boolen truth predicated on input values and
        /// report said adjudication by returning a bit (0/1) or system boolean value
        /// </summary>        
        Predicate = 128,
        
        
        /// <summary>
        /// Classifies an operation as a receiver
        /// </summary>        
        Receiver = Action | Unary,

        /// <summary>
        /// Classifies an operation as an emitter
        /// </summary>        
        Emitter = Function | Nullary,

        /// <summary>
        /// Classifies an operation as a unary function
        /// </summary>        
        UnaryFunction = Unary | Function,

        /// <summary>
        /// Classifies an operation as a binary function
        /// </summary>        
        BinaryFunction = Binary | Function,

        /// <summary>
        /// Classifies an operation as a ternary function
        /// </summary>        
        TernaryFunction = Ternary | Function,

        UnaryAction = Unary | Action,

        BinaryAction = Binary | Action,

        TernaryAction = Ternary | Action,

        UnaryOperator = Operator | Unary | Function,

        BinaryOperator = Operator | Binary | Function,

        TernaryOperator = Operator | Ternary | Function,

        /// <summary>
        /// Classifies an operation as a unary predicate
        /// </summary>        
        UnaryPred = Predicate | UnaryFunction,

        /// <summary>
        /// Classifies an operation as a binary predicate
        /// </summary>        
        BinaryPred = Predicate  | BinaryFunction,

        /// <summary>
        /// Classifies an operation as a ternary predicate
        /// </summary>        
        TernaryPred = Predicate  | TernaryFunction,                        

    }

    partial class ReflectedClass
    {
        /// <summary>
        /// Dtermines whether a method has a void return
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsAction(this MethodInfo m)
            => m.HasVoidReturn();

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFunction(this MethodInfo m)
            => ! m.HasVoidReturn();

        /// <summary>
        /// Queries the stream for methods that are functions
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Functions(this IEnumerable<MethodInfo> src)
            => src.Where(IsFunction);

        /// <summary>
        /// Queries the stream for methods that are actions
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Actions(this IEnumerable<MethodInfo> src)
            => src.Where(IsAction);
    }
}