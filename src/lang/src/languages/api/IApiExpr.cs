//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes an api expression
    /// </summary>
    public interface IApiExpr
    {
        dynamic Content {get;}
    }

    /// <summary>
    /// Characterizes a parametric api expression
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface IApiExpr<T> : IApiExpr
        where T : struct
    {
        new T Content {get;}

        dynamic IApiExpr.Content
            => Content;
    }
}