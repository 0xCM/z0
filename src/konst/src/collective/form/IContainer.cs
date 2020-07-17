//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Konst;
    
    /// <summary>
    /// Characterizes a parametric container
    /// </summary>
    /// <typeparam name="C"></typeparam>
    public interface IContainer<C>
    {

    }

    public interface IContainer<F,T> : IContainer<F>, IReified<F>
        where F : IContainer<F,T>, new()
    {

    }

    /// <summary>
    /// Characterizes a refified container over sequentially enumerable content
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="T">The element type</typeparam>
    public interface ISequential<F,T> : IContainer<F,T>
        where F : ISequential<F,T>, new()
        where T : IEnumerable<T>
    {
    
    }

    public interface ISequential<F,C,T> : IContainer<F,T>, IEnumerable<T>
        where F : ISequential<F,C,T>, new()
        where C : IEnumerable<T>
    {
    
    }

    /// <summary>
    /// Characterizes an immutable container
    /// </summary>
    /// <typeparam name="C">The content type</typeparam>
    public interface IReadOnly<C> : IContainer<C>
    {
        
    }
    

    /// <summary>
    /// Characterizes a reified immutable container
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="C">The content type</typeparam>
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
    public interface IReadOnly<F,C,T> : IReadOnly<F,C>, IContented<F,C,T>
        where F : IReadOnly<F,C,T>, new()
    {

    }
    
    /// <summary>
    /// Characterizes a (finite) free monoidal structure
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public interface IFreeMonoid<T> : IMonoid<T>, IConcatenable<T>, ICounted
    {

    }    

    public interface IFreeMonoid<F,S> : IMonoid<S>, IConcatenable<F,S>, ICounted, INullary<S>
        where F : IFreeMonoid<F,S>, new()
    {

    }    
    
    public interface IConcatenable<T>
    {

    }

    /// <summary>
    /// Characterizes a reification that defines an intrinsic concatentation operator
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface IConcatenable<F,T> : IConcatenable<T>
        where F : IConcatenable<F,T>, new()
    {
        /// <summary>
        /// Concatenates the intrinsic value with a suplied value 
        /// </summary>
        /// <param name="rhs">The right value supplied to the concatenation operator</param>
        F Concat(F rhs);
    }
    
    public interface IMaterialied<T> : IFinite, IContented<T>, IContentedIndex<T> 
    {

    }
    
    public interface IMaterialized<F,T> : IMaterialied<T>, IReified<F>
        where T : IFiniteDeferral<T>
        where F : IMaterialized<F,T>, new()
    {
        /// <summary>
        /// Replaces materialized content forced from a source
        /// </summary>
        /// <param name="src"></param>
        F Redefine(T src);
    }
    
    /// <summary>
    /// Characterizes a reversible structure
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IReversible<F,T>
        where F : IReversible<F,T>, new()
    {
        F Reverse();
    }    
}