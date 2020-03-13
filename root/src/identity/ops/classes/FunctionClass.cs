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
    using static ArityClass;

    /// <summary>
    /// Defines higher-kinded function classifications
    /// </summary>
    [Flags]
    public enum FunctionClass : ulong
    {
        None = 0,

        /// <summary>
        /// An operation that accepts no arguments and has a non-void return type
        /// </summary>
        Func0 = Nullary | Function,

        /// <summary>
        /// An operation that accepts one argument and has a non-void return type
        /// </summary>
        Func1 = Unary | Function,

        /// <summary>
        /// An operation that accepts two arguments and has a non-void return type
        /// </summary>
        Func2 = Binary | Function,

        /// <summary>
        /// An operation that accepts three arguments and has a non-void return type
        /// </summary>
        Func3 = Ternary | Function,
        
        /// <summary>
        /// A synonym for Func0
        /// </summary>
        Emitter = Func0,

        /// <summary>
        /// A synonym for Func1
        /// </summary>
        UnaryFunc = Func1,

        /// <summary>
        /// A synonym for Func2
        /// </summary>
        BinaryFunc = Func2,

        /// <summary>
        /// A synonym for Func3
        /// </summary>
        TernaryFunc = Func3,

        Converter = Pow2.T09 | UnaryFunc,

        Predicate = Pow2.T10,

        /// <summary>
        /// Classifies a function as a unary predicate
        /// </summary>        
        UnaryPred = Predicate | UnaryFunc,

        /// <summary>
        /// Classifies a function as a binary predicate
        /// </summary>        
        BinaryPred = Predicate  | BinaryFunc,

        /// <summary>
        /// Classifies a function as a ternary predicate
        /// </summary>        
        TernaryPred = Predicate  | TernaryFunc,                        

        /// <summary>
        /// Classifies a function that accepts one or more homogenous arguments and produces a numeric or enum value
        /// </summary>
        Measure = Pow2.T11,
        
        /// <summary>
        /// Classifies a unary function that returns a numeric or enum value
        /// </summary>
        UnaryMeasure = Measure | UnaryFunc,

        /// <summary>
        /// Classifies a homogenous binary function that returns a numeric or enum value
        /// </summary>
        BinaryMeasure = Measure | BinaryFunc,        

        /// <summary>
        /// Classifies a homogenous ternary function that returns a numeric or enum value
        /// </summary>
        TernaryMeasure = Measure | TernaryFunc,
        
        Vectorized = Pow2.T12,        

        V128 = Vectorized | Pow2.T13,
        
        V256 = Vectorized | Pow2.T14,

        Imm = Pow2.T20,

        /// <summary>
        /// Classifies unary functions that accepts an immediate value
        /// </summary>
        UnaryImm = Imm | UnaryFunc,

        /// <summary>
        /// Classifies functions that accept two arguments where at least one argument is an immediate value
        /// </summary>
        BinaryImm = Imm | BinaryFunc,
        
        /// <summary>
        /// Classifies functions that accept three arguments where at least one argument is an immediate value
        /// </summary>
        TernaryImm = Imm | TernaryFunc,

        Operator = Pow2.T21,

        UnaryOp = Operator | UnaryFunc,

        BinaryOp = Operator | BinaryFunc,

        TernaryOp = Operator | TernaryFunc,   

        Fixed = Pow2.T49,     

        Function = Pow2.T56

    } 

    partial class ReflectedClass
    {

    }    
}