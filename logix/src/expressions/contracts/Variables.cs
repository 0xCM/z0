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
    /// Characterizes a variable
    /// </summary>
    public interface IVarExpr : IExpr
    {
        /// <summary>
        /// The name of the variable
        /// </summary>
        string Name {get;}            

        void Set(IExpr value);

        IExpr Value {get;}
    }

    /// <summary>
    /// Characterizes a logical variable
    /// </summary>
    public interface ILogicVarExpr : IVarExpr, ILogicExpr
    {
        void Set(ILogicExpr value);

        void Set(bit value);

        new ILogicExpr Value {get;}

    }

    /// <summary>
    /// Characterizes a typed variable
    /// </summary>
    public interface IVarExpr<T> : IVarExpr, IExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// Gets the current value of the variable
        /// </summary>
        new IExpr<T> Value {get;}

        /// <summary>
        /// Sets the variable value
        /// </summary>
        void Set(IExpr<T> value);

        void Set(T value);
    }

    public interface ILiteralVarExpr<T> : IVarExpr, IExpr<T>
        where T : unmanaged
    {
        void Set(T value);

        new T Value {get;}
    }

}