//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    
    /// <summary>
    /// Defines higher-kinded function classifications
    /// </summary>
    [Flags]
    public enum FunctionKind : ulong
    {
        None = 0,

        /// <summary>
        /// An operation that accepts no arguments and has a non-void return type
        /// </summary>
        Func0 = Pow2.T00,

        /// <summary>
        /// An operation that accepts one argument and has a non-void return type
        /// </summary>
        Func1 = Pow2.T01,

        /// <summary>
        /// An operation that accepts two arguments and has a non-void return type
        /// </summary>
        Func2 = Pow2.T02,

        /// <summary>
        /// An operation that accepts three arguments and has a non-void return type
        /// </summary>
        Func3 = Pow2.T03,

        /// <summary>
        /// An operation that accepts four arguments and has a non-void return type
        /// </summary>
        Func4 = Pow2.T04,

        /// <summary>
        /// An operation that accepts five arguments and has a non-void return type
        /// </summary>
        Func5 = Pow2.T05,
        
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
    
        /// <summary>
        /// A function that returns an enum value
        /// </summary>
        LiteralFunc = Pow2.T15,

        Operator = Pow2.T40,
        
        Predicate = Pow2.T41,

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

        Converter = Pow2.T42 | UnaryFunc,

        Vectorized = Pow2.T45,        

        Imm = Pow2.T48,

        Fixed = Pow2.T49,

        V128 = Vectorized | Pow2.T46,
        
        V256 = Vectorized | Pow2.T47,

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

        UnaryOp = Operator | UnaryFunc,

        BinaryOp = Operator | BinaryFunc,

        TernaryOp = Operator | TernaryFunc,        

        /// <summary>
        /// Classifies a function that accepts one or more homogenous arguments and produces a numeric or enum value
        /// </summary>
        Measure = Pow2.T43,
        
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

        /// <summary>
        /// Classifies a measure that returns an enum value
        /// </summary>
        LiteralMeasure = Measure | LiteralFunc,
    } 
}