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


    /// <summary>
    /// Characterizes an untyped variable expression
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
    /// Characterizes a typed variable expression
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
    }

    public interface ILogicVar : ILogicExpr, IVarExpr<Bit>
    {

    }

    public interface IVariedExpr : IExpr
    {

    }

    public interface IVariedExpr<E,V> : IVariedExpr
        where E : IExpr
        where V : IVarExpr
    {

        E BaseExpr {get;}        

        V[] Vars {get;}        

        void SetVarValues(params E[] values);        
    }

    public interface IVariedExpr<N,E,V> : IVariedExpr<E,V>
        where E : IExpr
        where V : IVarExpr
        where N : ITypeNat, new()
    {
        
    }

    public interface IVariedLogicExpr : ILogicExpr, IVariedExpr<IExpr,ILogicVar>
    {

    }

    public interface IVariedLogicExpr<N> : ILogicExpr, IVariedExpr<N,IExpr,IVarExpr>
        where N : ITypeNat, new()
    {

    }




}