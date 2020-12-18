//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Identifies a class that classifies operations
    /// </summary>
    [Free]
    public interface IOperationalClass
    {

    }

    /// <summary>
    /// Characterizes a class-parametric operation class
    /// </summary>
    /// <typeparam name="E">The class type</typeparam>
    [Free]
    public interface IOperationalClass<E> : IOperationalClass
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
    public interface IOperationalClass<E,T> : IOperationalClass<E>
        where E : unmanaged, Enum
    {

    }

    [Free]
    public interface IOperationalClass<K,E,T> : IOperationalClass<E,T>
        where E : unmanaged, Enum
        where K : IOperationalClass<E>, new()
    {
        E IOperationalClass<E>.Kind => new K().Kind;
    }
}