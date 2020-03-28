//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public interface ICounted
    {
        ulong Count {get;}
    }

    public interface ICounted<T> : ICounted
        where T : unmanaged
    {
        new T Count {get;}
    }

    /// <summary>
    /// Characterizes a reified container
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    public interface IContainer<A>
    {
        A Content {get;}
    }

    /// <summary>
    /// Characterizes a reified container parametrized by the contained type
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The content aggregate</typeparam>
    public interface IContainer<C,A> : IContainer<A>
    {
        
    }

    /// <summary>
    /// Characterizes a reified container parametrized by the contained type
    /// </summary>
    /// <typeparam name="C">The container</typeparam>
    /// <typeparam name="A">The content aggregate</typeparam>
    /// <typeparam name="T">The contained item type</typeparam>
    public interface IContainer<C,A,T> : IContainer<C,A>
        where C : IContainer<C,A,T>, new()
    {
           
    }

    /// <summary>
    /// Characterizes a container that comprises discrete content
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface IEnumerableContainer<C,T> : IContainer<C,IEnumerable<T>, T>
        where C : IEnumerableContainer<C,T>, new()
    {
        
    }

    public interface INonEmpty<T>
        where T : INonEmpty<T>, new()
    {

    }

    /// <summary>
    /// Characterizes a set that contains at least one individual
    /// </summary>
    /// <typeparam name="T">The member type</typeparam>
    public interface INonempySet<T> 
        where T : INonempySet<T>, new()
    {

    }

    /// <summary>
    /// Characterizes a reifiable abstraction
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    public interface IConcrete<S>
        where S : IConcrete<S>, new()
    {

    }    


    /// <summary>
    /// Characterizes a set that contains at least one individual
    /// </summary>
    /// <typeparam name="T">The member type</typeparam>
    public interface NonempySet<S,T> : INonempySet<S>
        where S : NonempySet<S,T>, new()
    {

    }

    public interface IFiniteEnumerable<S,T> : IEnumerableContainer<S,T>, ICounted<int>
        where S : IFiniteEnumerable<S,T>, new()
    {
        ulong ICounted.Count => (ulong)Count;
    }

    /// <summary>
    /// Characterizes a reification that defines an intrinsic concatentation operator
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface IConcatenable<S> : IConcrete<S>
        where S : IConcatenable<S>, new()
    {
        /// <summary>
        /// Concatenates the intrinsic value with a suplied value 
        /// </summary>
        /// <param name="rhs">The right value supplied to the concatenation operator</param>
        S Concat(S rhs);
    }

    /// <summary>
    /// Characterizes a parametric conatenable thing 
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface IConcatenable<S,T> : IConcatenable<S>
        where S : IConcatenable<S,T>, new()
    {

    }    

    /// <summary>
    /// Characterizes a concatenable container with discrete content 
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface ISeq<S,T> : IEnumerableContainer<S,T>, IConcatenable<S,T>
        where S : ISeq<S,T>, new()
    {
        
    }

    public interface IIndexedSeq<T> : ICounted<int>
    {
        T this[int i] {get;}        
    }

    public interface IIndexedSeq<S,T> : ISeq<S,T>, IFiniteEnumerable<S,T>, IIndexedSeq<T>
        where S : IIndexedSeq<S,T>, new()
    {

    }
}