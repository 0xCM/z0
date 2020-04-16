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
    public interface IOpClass : IClassifier
    {

    }
    
    /// <summary>
    /// Charactrizes an operand-parametric operation class
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IOpClassT<T> : IClassT<T>
    {

    }

    /// <summary>
    /// Characterizes an F-bound polymorphic operation class
    /// </summary>
    /// <typeparam name="F">The reified type</typeparam>
    public interface IOpClassF<F> : IClassF<F>
        where F : IOpClassF<F>, new()
    {

    }
    
    /// <summary>
    /// Charactrizes a class-parametric operation class
    /// </summary>
    /// <typeparam name="E">The class type</typeparam>
    public interface IOpClass<E> : IOpClass 
        where E : unmanaged, Enum
    {
        E Class {get;}

        string Name => Class.ToString().ToLower();        
    }

    /// <summary>
    /// Charactrizes an operation class that both operand and class parametric
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="E">The class type</typeparam>
    public interface IOpClass<E,T> : IOpClass<E>, IOpClassT<T>
        where E : unmanaged, Enum
    {

    }

    /// <summary>
    /// Characterizes an operation class that is both class-parametric and F-bound polymorphic
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="E">The class type</typeparam>
    public interface IOpClassF<F,E> : IOpClass<E>, IClassF<F>
        where F : IOpClassF<F,E>, new()
        where E : unmanaged, Enum
    {

    }

    /// <summary>
    /// Charactrizes an operation class that is operand, class parametric, and F-bound polymorphic
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="E">The class type</typeparam>
    public interface IOpClassF<F,E,T> : IOpClass<E,T>, IOpClassF<F,E>
        where F : IOpClassF<F,E,T>, new()
        where E : unmanaged, Enum
    {

    }

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
        TypeWidth ISizedOpClass.Width => Widths.type<W>();
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
        where T : unmanaged
    {

    }    
}