//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a class that classifies operations
    /// </summary>
    public interface IOperationClass : IClass
    {

    }
    
    /// <summary>
    /// Charactrizes a class-parametric operation class
    /// </summary>
    /// <typeparam name="E">The class type</typeparam>
    public interface IOperationClass<E> : IOperationClass 
        where E : unmanaged, Enum
    {
        E Class {get;}

        string Name => Class.ToString().ToLower();        
    }

    /// <summary>
    /// Charactrizes a class-parametric operation class that is also operand-parametric
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="E">The class type</typeparam>
    public interface IOperationClass<E,T> : IOperationClass<E>
        where T : unmanaged
        where E : unmanaged, Enum
    {

    }


}