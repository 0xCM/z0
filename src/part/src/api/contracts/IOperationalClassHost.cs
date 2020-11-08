//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an operation class that is both class-parametric and F-bound polymorphic
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="E">The class type</typeparam>
    [Free]
    public interface IOperationalClassHost<F,E> : IOperationalClass<E>, IClassF<F>
        where F : IOperationalClassHost<F,E>, new()
        where E : unmanaged, Enum
    {

    }

    /// <summary>
    /// Characterizes an operation class that is operand, class parametric, and F-bound polymorphic
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="E">The class type</typeparam>
    [Free]
    public interface IOperationalClassHost<F,E,T> : IOperationalClass<E,T>, IOperationalClassHost<F,E>
        where F : IOperationalClassHost<F,E,T>, new()
        where E : unmanaged, Enum
    {

    }
}