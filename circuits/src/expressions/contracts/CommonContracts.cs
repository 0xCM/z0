//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public interface IExpr
    {
        ExprArity Arity {get;}
    }

    public interface IExpr<T> : IExpr
        where T : unmanaged
    {

    }

    public interface ILiteralExpr<T> : IExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The value of the literal
        /// </summary>
        T Value {get;}                
    }

    /// <summary>
    /// Characterizes an untyped variable expression
    /// </summary>
    public interface IVariableExpr : IExpr
    {
        /// <summary>
        /// The name of the variable
        /// </summary>
        string Name {get;}            

    }

    /// <summary>
    /// Characterizes a typed variable expression
    /// </summary>
    public interface IVariableExpr<T> : IVariableExpr
    {
        /// <summary>
        /// Gets the current value of the variable
        /// </summary>
        T Value {get;}

        /// <summary>
        /// Sets the variable value
        /// </summary>
        void Set(T value);
    }

}