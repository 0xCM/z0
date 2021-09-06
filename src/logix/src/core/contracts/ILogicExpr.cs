//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a logical expression over a bit
    /// </summary>
    public interface ILogicExpr : IExpr
    {

    }

    /// <summary>
    /// Characterizes a typed expression that admits logical evaluation
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface ILogicExpr<T> : ILogicExpr, IExpr<T>
        where T : unmanaged
    {

    }
}