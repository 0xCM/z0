//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an operation class that classifies width-parametric operations
    /// </summary>
    [Free]
    public interface ISizedClass : IOperationClass
    {
        TypeWidth Width {get;}
    }

    /// <summary>
    /// Characterizes a width-parametric operation class
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [Free]
    public interface ISizedClass<W> : ISizedClass
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a width-parametric operation class that is also class-parametric
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="E">The class type</typeparam>
    [Free]
    public interface ISizedClass<W,E> : ISizedClass<W>, IOperationClass<E>
        where W : unmanaged, ITypeWidth
        where E : unmanaged, Enum
    {

    }

    /// <summary>
    /// Characterizes an operation class, parametric in both width and class, is also operand-parametric
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="E">The class type</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    [Free]
    public interface ISizedClass<W,E,T> : ISizedClass<W>, IOperationClass<E,T>
        where W : unmanaged, ITypeWidth
        where E : unmanaged, Enum
    {

    }
}