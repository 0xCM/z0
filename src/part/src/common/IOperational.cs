//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Identifies a class that classifies operations
    /// </summary>
    [Free]
    public interface IOperational : IClassifier
    {

    }

    /// <summary>
    /// Characterizes an operand-parametric operation class
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [Free]
    public interface IOperationalT<T> : IClassT<T>
    {

    }

    /// <summary>
    /// Characterizes a class-parametric operation class
    /// </summary>
    /// <typeparam name="E">The class type</typeparam>
    [Free]
    public interface IOperational<E> : IOperational
        where E : unmanaged, Enum
    {
        E Kind {get;}

        string Name
            => Kind.ToString().ToLower();
    }

    /// <summary>
    /// Characterizes an operation class that both operand and class parametric
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="E">The class type</typeparam>
    [Free]
    public interface IOperational<E,T> : IOperational<E>, IOperationalT<T>
        where E : unmanaged, Enum
    {

    }

    [Free]
    public interface IOperational<K,E,T> : IOperational<E,T>
        where E : unmanaged, Enum
        where K : IOperational<E>, new()
    {
        E IOperational<E>.Kind => new K().Kind;
    }

    /// <summary>
    /// Characterizes an operation class that is both class-parametric and F-bound polymorphic
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="E">The class type</typeparam>
    [Free]
    public interface IOperationalF<F,E> : IOperational<E>, IClassF<F>
        where F : IOperationalF<F,E>, new()
        where E : unmanaged, Enum
    {

    }

    /// <summary>
    /// Characterizes an operation class that is operand, class parametric, and F-bound polymorphic
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="E">The class type</typeparam>
    [Free]
    public interface IOperationalF<F,E,T> : IOperational<E,T>, IOperationalF<F,E>
        where F : IOperationalF<F,E,T>, new()
        where E : unmanaged, Enum
    {

    }
}