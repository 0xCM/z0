//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;


    public interface IContentAggregate : ICustomFormattable
    {
        IEnumerable<object> Items {get;}

        string ICustomFormattable.Format()
            => string.Join(AsciSym.Comma, Items);

    }

    public interface IContentAggregate<T> : IContentAggregate, IEnumerable<T>
    {
        new IEnumerable<T> Items {get;}

        IEnumerable<object> IContentAggregate.Items
            => Items.Cast<object>();

        IEnumerator IEnumerable.GetEnumerator()
            => Items.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Items.ToReadOnlyList().GetEnumerator();

    }

    /// <summary>
    /// Characterizes a reified container
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    public interface IContainer<A>
        //where S : IContainer<S>, new()
    {
        A Content {get;}
    }

    /// <summary>
    /// Characterizes a reified container parametrized by the contained type
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The content aggregate</typeparam>
    public interface IContainer<C,A> : IContainer<A>
        //where C : IContainer<C,A>, new()
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


    public interface IFiniteEnumerable<S,T> : IEnumerableContainer<S,T>
        where S : IFiniteEnumerable<S,T>, new()
    {
        /// <summary>
        /// The count providing evidence that the content is finite
        /// </summary>
        int Count {get;}
    }


    public interface IIndexedSeq<S,T> : ISeq<S,T>, IFiniteEnumerable<S,T>
        where S : IIndexedSeq<S,T>, new()
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
    /// Characterizes a concatenable container with discrete content 
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface ISeq<S,T> : IEnumerableContainer<S,T>, IConcatenable<S,T>
        where S : ISeq<S,T>, new()
    {
        
    }


    /// <summary>
    /// Characteriizes a reified set for which there are a countable number of members
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface IDiscreteSet<S,T> : IFormalSet, IEnumerableContainer<S,T>
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

    public interface IConcurrentLookup<K,V>
    {
        V Acquire(K key, Func<K,V> factory);
        void Add(K key, V value);        
    }
}