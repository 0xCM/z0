//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    /// <summary>
    /// Distinguishes varied expressions from other sorts of expressions
    /// </summary>
    public interface IVariedExpr : IExpr
    {

    }

    /// <summary>
    /// Characterizes an expression that varies over a typed expression
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface IVariedExpr<T> : IVariedExpr, IExpr<T>
        where T : unmanaged
    {
        IExpr<T> BaseExpr {get;}

        IVarExpr<T>[] Vars {get;}

        void SetVars(params IExpr<T>[] values);        

        void SetVars(params T[] values);
    }
}