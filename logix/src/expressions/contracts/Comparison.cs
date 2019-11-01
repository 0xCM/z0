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


    /// <summary>
    /// Characterizes a claim that two variable-dependent comparison expressions are equivalent
    /// </summary>
    public interface IComparisonExpr : ILogicExpr
    {
        /// <summary>
        /// The left expression
        /// </summary>
        ILogicExpr Lhs {get;}
        
        /// <summary>
        /// The right expression
        /// </summary>
        ILogicExpr Rhs {get;}

        /// <summary>
        /// Variables upon which the expression depends
        /// </summary>
        LogicVariable[] Vars {get;}
        
    }

    /// <summary>
    /// Characterizes a claim that two variable-dependent typed comparison expressions are equivalent
    /// </summary>
    public interface IComparisonExpr<T> : IExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The left expression
        /// </summary>
        IExpr<T> LeftArg {get;}
        
        /// <summary>
        /// The right expression
        /// </summary>
        IExpr<T> RightArg {get;}

        /// <summary>
        /// Variables upon which the expression depends
        /// </summary>
        VariableExpr<T>[] Vars {get;}

        /// <summary>
        /// The sort of comparison to be applied
        /// </summary>
        ComparisonKind ComparisonKind {get;}
    }


    /// <summary>
    /// Characterizes a comparison expression that evaluates as a predicate where a single bit characterizes the evaluation result,
    /// in contradistinction to the more general typed comparison expression where the result is predicated on the type
    /// and may be scalar/vector/etc in nature
    /// </summary>
    /// <typeparam name="T">The type over which the comparison is defined</typeparam>
    public interface IComparisonPred<T> : IComparisonExpr<T> 
        where T : unmanaged
    {

    }
}