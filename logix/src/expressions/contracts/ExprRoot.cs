//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;

    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;


    /// <summary>
    /// Characterizes an expression
    /// </summary>
    public interface IExpr
    {
        /// <summary>
        /// Renders the expression in canonical form
        /// </summary>
        string Format();   
    }

    /// <summary>
    /// Characterizes a logicical expression over a bit
    /// </summary>
    public interface ILogicExpr : IExpr
    {
        /// <summary>
        /// Specifies the class to which the expression belongs
        /// </summary>
        LogicExprKind ExprKind {get;}
    }

    /// <summary>
    /// Characterizes an expression over an unmanaged type
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface ITypedExpr<T> : IExpr
        where T : unmanaged
    {
        /// <summary>
        /// Specifies the class to which the expression belongs
        /// </summary>
        TypedExprKind ExprKind {get;}
    }
    

}