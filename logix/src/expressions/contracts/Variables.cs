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

    /// <summary>
    /// Characterizes a logical variable
    /// </summary>
    public interface ILogicVarExpr : IVarExpr, ILogicExpr
    {
        /// <summary>
        /// Updates the variable
        /// </summary>
        /// <param name="expr">The value to assigned to the variable</param>
        void Set(ILogicExpr expr);

        /// <summary>
        /// Updates the expression value
        /// </summary>
        /// <param name="literal">The literal value to assign to the variable</param>
        void Set(bit literal);
        
        ILogicExpr Value {get;}
    }


    /// <summary>
    /// Characterizes a typed variable
    /// </summary>
    public interface IVarExpr<T> : IVarExpr, IExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// Updates the variable
        /// </summary>
        /// <param name="expr">The value to assigned to the variable</param>
        void Set(IExpr<T> expr);

        /// <summary>
        /// Updates the expression value
        /// </summary>
        /// <param name="literal">The literal value to assign to the variable</param>
        void Set(T literal);
        
        IExpr<T> Value {get;}

    }

    public interface ILogicVarExpr<T> :  IVarExpr, ILogicExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// Updates the variable
        /// </summary>
        /// <param name="expr">The value to assigned to the variable</param>
        void Set(ILogicExpr<T> expr);

        /// <summary>
        /// Updates the expression value
        /// </summary>
        /// <param name="literal">The literal value to assign to the variable</param>
        void Set(T literal);
        
        ILogicExpr<T> Value {get;}


    }

}