//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
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

    public interface IContainer 
    {

    }

    /// <summary>
    /// Characterizes a reified container
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    public interface IContainer<A> : IContainer
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

    public interface IItemContainer<T> : IContainer<IEnumerable<T>>, IEnumerable<T>
    {
        IEnumerator IEnumerable.GetEnumerator()
            => Content.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Content.ToList().GetEnumerator();
    }


    /// <summary>
    /// Characterizes a container that comprises discrete content
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface IItemContainer<C,T> :  IItemContainer<T>, IContainer<C,IEnumerable<T>, T>
        where C : IItemContainer<C,T>, new()
    {
        
    }

    public interface IIndexContainer<T> : IContainer<T[]>, IEnumerable<T>
    {
        IEnumerator IEnumerable.GetEnumerator()
            => Content.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Content.ToList().GetEnumerator();

        int Length
            => Content.Length;
        
        ref T this[int index]
        {         
            get => ref Content[index];
        }
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
    /// Characteriizes a reified set for which there are a countable number of members
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface IDiscreteSet<S,T> : IFormalSet, IItemContainer<S,T>
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

    public interface IIndexed<F> : IIndexed
        where F : struct, IIndexed<F>
    {
        
    }

    public interface IIndexed<F,N> : IIndexed<F>, ITypeNat<N>
        where F : struct, IIndexed<F,N>
        where N : unmanaged, ITypeNat
    {
        ulong ITypeNat.NatValue => default(N).NatValue;

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

    public interface IFiniteEnumerable<S,T> : IItemContainer<S,T>, ICounted<int>
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
    public interface ISeq<S,T> : IItemContainer<S,T>, IConcatenable<S,T>
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

    public interface ISemigroup<S>
        where S : ISemigroup<S>, new()
    {

    }

    public interface ISemigroup<S,T> : ISemigroup<S>
        where S : ISemigroup<S,T>, new()
    {
        
    }            

    /// <summary>
    /// Characterizes a suject that is in correspondece with an index-identified sequence element
    /// </summary>
    public interface ISequential
    {
        /// <summary>
        /// The sequence index
        /// </summary>
        int Index {get;}
    }

    /// <summary>
    /// Characterizes a reified sequential
    /// </summary>
    public interface ISequential<T> : ISequential
        where T: ISequential<T>, new()
    {

    }

    public interface ISeq<T> : IItemContainer<T>
    {        

    }

    public interface IEquatableSeq<C,T> : ISeq<T>, IEquatable<C>
        where C: IEquatableSeq<C,T>, new()         
    {
        
        /// <summary>
        /// It is not assumed that sequence is finite; in discrete computing
        /// context, concrete evaluation (i.e. non-symbolic evaluation) of
        /// infinite...anything...isn't possible. Equality evaluation of two (potentially) infinite 
        /// sequences is not a well-defined operation and in the face of problem, the only
        /// think that can be done to make it a well-defined operation is to simply define
        /// the result to be false, which is what is done here
        /// </summary>
        /// <param name="src">The sequenct that will not be compared to this one</param>
        bool IEquatable<C>.Equals(C src)
            => false;
    }

    public interface IFiniteSeq<T> : IIndexContainer<T>
    {

    }

    public interface IFiniteSeq<C,T> :  IFiniteSeq<T>, IEquatable<C>
        where C : IFiniteSeq<C,T>, new()         
    {        
        bool IEquatable<C>.Equals(C src)
            => Enumerable.SequenceEqual(this, src);
    }
}