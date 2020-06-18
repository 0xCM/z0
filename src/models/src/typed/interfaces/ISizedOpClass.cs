//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes an operation class that classifies width-parametric operations
    /// </summary>
    public interface ISizedOpClass : IOpClass
    {
        TypeWidth Width {get;}
    }

    /// <summary>
    /// Characterizes a width-parametric operation class
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    public interface ISizedOpClass<W> : ISizedOpClass
        where W : unmanaged, ITypeWidth
    {
        
    }
        
    /// <summary>
    /// Characterizes a width-parametric operation class that is also class-parametric
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="E">The class type</typeparam>
    public interface ISizedOpClass<W,E> : ISizedOpClass<W>, IOpClass<E>
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
    public interface ISizedOpClass<W,E,T> : ISizedOpClass<W>, IOpClass<E,T>
        where W : unmanaged, ITypeWidth
        where E : unmanaged, Enum
    {

    }    
}