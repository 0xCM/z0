//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes  a type that  exhibits a notion of length
    /// </summary>
    public interface ILengthwise
    {
        int Length {get;}
    }

    /// <summary>
    /// Characterizes  a type that  exhibits a notion of length
    /// </summary>
    public interface ILengthwise<S> : ILengthwise
        where S : ILengthwise<S>, new()
    {

    }

    public interface ICounted
    {
        int Count {get;}
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
    /// Characterizes an individual that can be uniquely associatd with an integer in the range 0..n-1 
    /// within the context of a container with a capacity of n items
    /// </summary>
    public interface IIndexed
    {
        /// <summary>
        /// The 0-based position of the item in an enclosing container
        /// </summary>
        int Position {get;}
    }

    public interface IIndexed<I> : IIndexed
        where I : struct, IIndexed<I>
    {
        
    }

    /// <summary>
    /// Characterizes a container I with immutable content such that: 
    /// - I has a capacity of n items where n is determined when a reification 
    /// is instantiated and remains fixed throught its lifetime
    /// - I maintaines A bijection between the integers {0,.., n-1} and the contained elements 
    /// that also remains fixed
    /// </summary>
    public interface IReadOnlyIndex<T>
    {
        ref readonly T this[int index] {get;}

        /// <summary>
        /// The number of indexed items
        /// </summary>
        int Length {get;}
    }

    /// <summary>
    /// Characterizes a container C with mutable content such that: 
    /// - C has a capacity of n items where n is determined when a reification 
    /// is instantiated and remains fixed throught its lifetime
    /// - C maintaines A bijection between the integers {0,.., n-1} and the contained elements 
    /// that also remains fixed
    /// </summary>
    public interface IIndex<T> : IReadOnlyIndex<T>
    {
        new ref T this[int index] {get;}

        ref readonly T IReadOnlyIndex<T>.this[int index] 
        {
            get => ref this[index];
        }
    }

    /// <summary>
    /// Characterizes an indexed sequence
    /// </summary>
    /// <typeparam name="T">The sequence element type</typeparam>
    public interface IIndexedSeq<T> : ICounted<int>
    {
        T this[int i] {get;}        
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
        int ICounted.Count => Count;
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


    /// <summary>
    /// Characterizes a reifed indexed sequence
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    /// <typeparam name="T">The sequence element type</typeparam>
    public interface IIndexedSeq<S,T> : ISeq<S,T>, IFiniteEnumerable<S,T>, IIndexedSeq<T>
        where S : IIndexedSeq<S,T>, new()
    {

    }
}