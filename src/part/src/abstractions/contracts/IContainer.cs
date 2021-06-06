//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;


    /// <summary>
    /// Characterizes an immutable container
    /// </summary>
    /// <typeparam name="C">The content type</typeparam>
    [Free]
    public interface IReadOnly<C> : IContainer<C>
    {

    }


    /// <summary>
    /// Characterizes a reified immutable container
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="C">The content type</typeparam>
    [Free]
    public interface IReadOnly<F,C> : IReadOnly<C>, IContented<F,C>
        where F : IReadOnly<F,C>, new()
    {

    }

    /// <summary>
    /// Characterizes a reified immutable container with T-stratified content
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="C">The content type</typeparam>
    /// <typeparam name="T">The type over which the content is stratified</typeparam>
    [Free]
    public interface IReadOnly<F,C,T> : IReadOnly<F,C>, IContented<F,C,T>
        where F : IReadOnly<F,C,T>, new()
    {

    }

    /// <summary>
    /// Characterizes a (finite) free monoidal structure
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    [Free]
    public interface IFreeMonoid<T> : IMonoid<T>, IConcatenable<T>, ICounted
    {

    }

    [Free]
    public interface IFreeMonoid<F,S> : IMonoid<S>, IConcatenable<F,S>, ICounted, INullary<S>
        where F : IFreeMonoid<F,S>, new()
        where S : new()
    {

    }

    /// <summary>
    /// Characterizes a reversible structure
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    [Free]
    public interface IReversible<F,T>
        where F : IReversible<F,T>, new()
    {
        F Reverse();
    }
}