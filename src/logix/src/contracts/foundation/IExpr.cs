//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes an expression
    /// </summary>
    public interface IExpr : ITextual
    {


    }

    /// <summary>
    /// Characterizes an parametric expression
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface IExpr<T> : IExpr
        where T : unmanaged
    {

    }

    public interface IExpr<F,T>
        where T : unmanaged
        where F : unmanaged, IExpr<F,T>
    {


    }

}