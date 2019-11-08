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
        
        /// <summary>
        /// The current value of the variable
        /// </summary>
        IExpr<T> Value {get;}

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
        
        /// <summary>
        /// The current value of the variable
        /// </summary>
        ILogicExpr Value {get;}
    }



    /// <summary>
    /// Characterizes a logical variable that also carries type information
    /// </summary>
    public interface ILogicVarExpr<T> :  ILogicVarExpr, ILogicExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// Updates the variable
        /// </summary>
        /// <param name="expr">The value to assigned to the variable</param>
        void Set(ILogicExpr<T> expr);

        
        /// <summary>
        /// The current value of the variable
        /// </summary>
        new ILogicExpr<T> Value {get;}


    }

}