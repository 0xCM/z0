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
    public enum HKFunctionKind : ulong
    {
        None = 0,

        Emitter = Pow2.T01,

        UnaryFunc = Pow2.T02,

        BinaryFunc = Pow2.T03,

        TernaryFunc = Pow2.T04,

        Operator = Pow2.T40,
        
        Predicate = Pow2.T41,

        Conveter = Pow2.T42,

        /// <summary>
        /// Classifies functions that produce scalar values
        /// </summary>
        Measure = Pow2.T43,

        Blocked = Pow2.T44,

        Vectorized = Pow2.T45,

        Imm = Pow2.T48,

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
        
        UnaryPred = Predicate | UnaryFunc,

        BinaryPred = Predicate  | BinaryFunc,

        TernaryPred = Predicate  | TernaryFunc,
                
        UnaryConverter = Conveter | UnaryFunc,

        BinaryConverter = Conveter | BinaryFunc,

        UnaryMeasure = Measure | UnaryFunc,

        BinaryMeasure = Measure | BinaryFunc,        

        TernaryMeasure = Measure | TernaryFunc,        
    }
}