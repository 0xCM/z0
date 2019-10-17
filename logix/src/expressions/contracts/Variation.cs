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
    public interface IVariable : IExpr
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
    public interface IVariable<T> : IVariable, IExpr<T>
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

    public interface IlogicVariable : ILogicExpr, IVariable
    {
        void Set(ILogicExpr value);

        new ILogicExpr Value {get;}

    }

    public interface IVaried : IExpr
    {

    }

    public interface IVaried<E,V> : IVaried
        where E : IExpr
        where V : IVariable
    {

        E BaseExpr {get;}        

        V[] Vars {get;}        

        void SetVarValues(params E[] values);        
    }

    public interface IVaried<N,E,V> : IVaried<E,V>
        where E : IExpr
        where V : IVariable
        where N : ITypeNat, new()
    {
        
    }

    public interface IVariedLogicExpr : ILogicExpr, IVaried<IExpr,IlogicVariable>
    {

    }

    public interface IVariedLogicExpr<N> : ILogicExpr, IVaried<N,IExpr,IVariable>
        where N : ITypeNat, new()
    {

    }




}