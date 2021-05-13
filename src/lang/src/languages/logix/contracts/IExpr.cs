//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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
        where T : struct
    {

    }

    public interface IExpr<F,T> : IExpr<T>
        where T : struct
        where F : struct, IExpr<F,T>
    {

    }
}