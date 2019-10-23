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
    /// Characterizes a multi-varied expression that represents a question or claim
    /// regarding the equality of two untyped logic expressions
    /// </summary>
    public interface IEqualityExpr : ILogicExpr
    {
        /// <summary>
        /// The left expression
        /// </summary>
        ILogicExpr Lhs {get;}
        
        /// <summary>
        /// The right expression
        /// </summary>
        ILogicExpr Rhs {get;}

        LogicVariable[] Vars {get;}
        
    }

    /// <summary>
    /// Characterizes a multi-varied expression that represents a question or claim
    /// regarding the equality of two typed logic expressions
    /// </summary>
    public interface IEqualityExpr<T> : IExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The left expression
        /// </summary>
        IExpr<T> Lhs {get;}
        
        /// <summary>
        /// The right expression
        /// </summary>
        IExpr<T> Rhs {get;}

        VariableExpr<T>[] Vars {get;}

    }

    public interface ILieralEqualityExpr<T> : IExpr<T>
        where T : unmanaged
    {

    }

}