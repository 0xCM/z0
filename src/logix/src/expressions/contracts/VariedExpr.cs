//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
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

    /// <summary>
    /// Characterizes an expression that depends on a boolean variable
    /// </summary>
    public interface IVariedLogicExpr : IVariedExpr, ILogicExpr
    {
        ILogicExpr BaseExpr {get;}        

        ILogicVarExpr[] Vars {get;}        

        void SetVars(params ILogicExpr[] values);        

        void SetVars(params bit[] values);        
    }

    /// <summary>
    /// Characterizes an expression that depends on a boolean variable but which
    /// also carries type information
    /// </summary>
    public interface IVariedLogicExpr<T> : IVariedLogicExpr,  ILogicExpr<T>
        where T : unmanaged
    {
     
        new ILogicExpr<T> BaseExpr {get;}        

        new ILogicVarExpr<T>[] Vars {get;}        

        void SetVars(params ILogicExpr<T>[] values);        
    }
}