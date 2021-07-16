//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a reified constant value
    /// </summary>
    /// <typeparam name="T">The constant type</typeparam>
    public interface IConstExpr<H,T> : IConstant<T>, ISyntax<H>
        where H : IConstExpr<H,T>, new()
    {

    }
}