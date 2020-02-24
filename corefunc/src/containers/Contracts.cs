//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    /// <summary>
    /// Characterizes a reified container
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    public interface IContainer<S>
        where S : IContainer<S>, new()
    {
        
    }

    /// <summary>
    /// Characterizes a reified container parametrized by the contained type
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface IContainer<S,T> : IContainer<S>
        where S : IContainer<S,T>, new()
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
    /// Characterizes a set that contains at least one individual
    /// </summary>
    /// <typeparam name="T">The member type</typeparam>
    public interface NonempySet<S,T> : INonempySet<S>
        where S : NonempySet<S,T>, new()
    {

    }

    /// <summary>
    /// Characterizes a container that comprises discrete content
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface IDiscreteContainer<S,T> : IContainer<S,T>
        where S : IDiscreteContainer<S,T>, new()
    {
        IEnumerable<T> Content {get;}
    }

    public interface IFiniteContainer<S,T> : IDiscreteContainer<S,T>
        where S : IFiniteContainer<S,T>, new()
    {
        /// <summary>
        /// The count providing evidence that the content is finite
        /// </summary>
        int Count {get;}
    }

    public interface IFiniteSeq<S,T> : ISeq<S,T>, IFiniteContainer<S,T>
        where S : IFiniteSeq<S,T>, new()
    {
        /// <summary>
        /// Retrieves the 0-based i'th element of the sequence
        /// </summary>
        T this[int i] {get;}
    }

    /// <summary>
    /// Characterizes a set that, if nonempty, contains elements of unknown type
    /// </summary>
    public interface IFormalSet
    {
        /// <summary>
        /// Specifies whether the set is void of elements
        /// </summary>
        bool IsEmpty {get;}

        /// <summary>
        /// Specifies whether the set is finite
        /// </summary>
        bool IsFinite {get;}

        /// <summary>
        /// Specifies whether the set is discrete
        /// </summary>
        bool IsDiscrete {get;}
    }

    /// <summary>
    /// Characterizes a reified set
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface IFormalSet<S,T> : IFormalSet, IContainer<S,T>
        where S : IFormalSet<S,T>, new()
    {
    
    }

    /// <summary>
    /// Characterizes a concatenable container with discrete content 
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface ISeq<S,T> : IDiscreteContainer<S,T>, IConcatenable<S,T>
        where S : ISeq<S,T>, new()
    {
        
    }

    /// <summary>
    /// Characterizes a set indexed by another set
    /// </summary>
    /// <typeparam name="I">The indexing set</typeparam>
    /// <typeparam name="X">The indexed set</typeparam>
    public interface IIndex<I,T> : IDiscreteContainer<I,KeyedValue<I,T>>
        where I : IIndex<I,T>, new()
    {
        /// <summary>
        /// Retrives an indexed value
        /// </summary>
        /// <param name="index">The index value</param>
        /// <returns>The indexed value</returns>
        T Lookup(I index);

        /// <summary>
        /// Retrives an indexed value via an index operator
        /// </summary>
        /// <param name="index">The index value</param>
        /// <returns>The indexed value</returns>
        T  this[I ix] {get;}
    }

    /// <summary>
    /// Characteriizes a reified set for which there are a countable number of members
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface IDiscreteSet<S,T> : IFormalSet, IDiscreteContainer<S,T>
        where S: IDiscreteSet<S,T>, new()
    {

    }

    /// <summary>
    /// Characteriizes a reified set that contains a finite number of values
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface IFiniteSet<S,T> : IDiscreteSet<S,T>
        where S : IFiniteSet<S,T>, new()
    {
        /// <summary>
        /// Evidence that the set is indeed finite
        /// </summary>
        int Count {get;}

        /// <summary>
        /// Determines whether a value is a member
        /// </summary>
        /// <param name="candidate">The potential member to check</param>
        bool Contains(T candidate);

        /// <summary>
        /// Determines whether the current set is a subset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate superset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        bool IsSubset(S rhs, bool proper = true);
        
        /// <summary>
        /// Determines whether the current set is a superset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate subset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        bool IsSuperset(S rhs, bool proper = true);

        /// <summary>
        /// Calculates the union between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to union/param>
        S Union(S rhs);
        
        /// <summary>
        /// Calculates the intersection between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to intersect</param>
        S Intersect(S rhs);
        
        /// <summary>
        /// Calculates the set difference, or symmetric difference, between the current 
        /// set and a specified set and returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set that should be differenced</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Symmetric_difference</remarks>
        S Difference(S rhs, bool symmetric = false);
    }

    public interface IReadOnlyLookup<K,V>
    {
        V Find(K key);

        bool Find(K key, out V value);

        V this[K key] {get;}

        Option<V> TryFind(K key);
        
    }
    
    public interface ILookup<K,V> : IReadOnlyLookup<K,V>
    {
        void Add(K key, V value);
        
        bool TryAdd(K key, V value);
        
        void AddOrReplace(K key, V value);
    }

}