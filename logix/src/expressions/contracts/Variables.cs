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

    }

    public interface IVarExpr<T,X> : IVarExpr, IExpr<T>
        where T : unmanaged
        where X : IExpr
        
    {
        /// <summary>
        /// Updates the variable
        /// </summary>
        /// <param name="expr">The value to assigned to the variable</param>
        void Set(X expr);

        /// <summary>
        /// Updates the expression value
        /// </summary>
        /// <param name="literal">The literal value to assign to the variable</param>
        void Set(T literal);
        
        X Value {get;}
    }

    /// <summary>
    /// Characterizes a logical variable
    /// </summary>
    public interface ILogicVarExpr : IVarExpr<bit,ILogicExpr>, ILogicExpr
    {

    }

    /// <summary>
    /// Characterizes a typed variable
    /// </summary>
    public interface IVarExpr<T> : IVarExpr<T, IExpr<T>>
        where T : unmanaged
    {

    }


}