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

    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Characterizes an F-bound polymorphic reifiable abstraction
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    public interface IReified<F>
        where F : IReified<F>, new()
    {

    }    


    public interface ISemigroup<F> : IReified<F>
        where F : ISemigroup<F>, new()
    {

    }

    public interface ISemigroup<S,T> : ISemigroup<S>
        where S : ISemigroup<S,T>, new()
    {
        
    }            

    /// <summary>
    /// Characterizes a parametric container
    /// </summary>
    /// <typeparam name="C"></typeparam>
    public interface IContainer<C>
    {

    }

    public interface IContainer<F,T> : IContainer<F>
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
    /// Characterizes a container that owns content
    /// </summary>
    /// <typeparam name="C">The content type</typeparam>
    public interface IContented<C> : IContainer<C>
    {
        C Content {get;}
    }

    /// <summary>
    /// Characterizes reified container
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="C">The content type</typeparam>
    public interface IContented<F,C> : IContented<C>, IReified<F>
        where F : IContented<F,C>, new()
    {
        /// <summary>
        /// Assigns content; whether existing content is replaced, accrued or
        /// if a new container is created is determined by the reifying type 
        /// and its purpose in life
        /// </summary>
        /// <param name="content">The source content</param>
        F WithContent(C content);
    }

    /// <summary>
    /// Characterizes a reified container with T-stratified content
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="C">The content type</typeparam>
    /// <typeparam name="T">The type over which the content is stratified</typeparam>
    public interface IContented<F,C,T> : IContented<F,C>
        where F : IContented<F,C,T>, new()
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
    /// Characterizes a type for which a well-defined Count() function can be implemented
    /// such types will be referred to as "countable" athough this terminology unfortunately conflicts
    /// with mathematical countability wich only requries the existence of a bijection with
    /// the subject and the natural numbers which does imply that the cardinality is finite
    /// </summary>
    public interface IFinite
    {
        /// <summary>
        /// Counts the finite things
        /// </summary>
        int Count();   
    }

    /// <summary>
    /// Characterizes a finite type type with a parametric count emitter since not all
    /// countable things can be counted with a 32-bit integer
    /// </summary>
    /// <typeparam name="T">The count type</typeparam>
    public interface IFinite<T> : IFinite
    {
        new T Count();
    
        int IFinite.Count() 
            => (int)(object)Count();
    }

    /// <summary>
    /// Characterizes a finite thing that yeilds a count value that does not require computation/enumeration 
    /// to reveal; in other words, the count function for counted things is free, as evinced by
    /// the default implementation
    /// </summary>
    public interface ICounted : IFinite
    {
        /// <summary>
        /// The count value
        /// </summary>
        new int Count {get;}

        [MethodImpl(Inline)]
        int IFinite.Count() 
            => Count;
    }

    /// <summary>
    /// Characterizes a countable type with a parametric count type since not all
    /// countable things can be counted with a 32-bit integer
    /// </summary>
    /// <typeparam name="T">The count type</typeparam>
    public interface ICounted<T> : ICounted, IFinite<T>
    {
        new T Count {get;}

        [MethodImpl(Inline)]
        T IFinite<T>.Count() 
            => Count;
    }

    /// <summary>
    /// Characterizes a type that exhibits a notion of finite length
    /// </summary>
    public interface ILengthwise : ICounted
    {
        int Length {get;}

        int ICounted.Count 
            => Length;
    }


    /// <summary>
    /// Characterizes a refiied type that  exhibits a notion of length
    /// </summary>
    public interface ILengthwise<S> : ILengthwise, IReified<S>
        where S : ILengthwise<S>, new()
    {

    }
    
    /// <summary>
    /// Defines attributes common to set representations
    /// </summary>
    public interface ISetAspect
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
    /// Characterizes a reification that defines an intrinsic concatentation operator
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface IConcatenable<S> : IReified<S>
        where S : IConcatenable<S>, new()
    {
        /// <summary>
        /// Concatenates the intrinsic value with a suplied value 
        /// </summary>
        /// <param name="rhs">The right value supplied to the concatenation operator</param>
        S Concat(S rhs);
    }

    /// <summary>
    /// Characterizes a container over discrete/enumerable content which need not be finite
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IElements<T> : IContented<IEnumerable<T>>, IEnumerable<T>
    {
        IEnumerator IEnumerable.GetEnumerator()
            => Content.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Content.ToList().GetEnumerator();
    }

    /// <summary>
    /// Characterizes a reified container over discrete/enumerable content which need not be finite
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="T">The element type</typeparam>
    public interface IElements<F,T> :  IElements<T>, IContented<F,IEnumerable<T>,T>, IReified<F>, IConcatenable<F>
        where F : IElements<F,T>, new()
    {
        F IConcatenable<F>.Concat(F rhs)
            => WithContent(Content.Concat(rhs.Content));
        
    }

    /// <summary>
    /// Characterizes a set over a collection of elements and need not be finite
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IDiscreteSet<T> : ISetAspect, IElements<T>
    {

    }

    /// <summary>
    /// Characteriizes refied discrete set
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface IDiscreteSet<F,T> : IDiscreteSet<T>, IElements<F,T>
        where F: IDiscreteSet<F,T>, new()
    {

    }

    /// <summary>
    /// Characterizes a reified nonempty set
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    public interface INonempySet<F> : INonEmpty<F>, ISetAspect
        where F : INonempySet<F>, new()
    {

    }

    /// <summary>
    /// Characterizes a reified nonempty set with evidence of non-absence
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface NonempySet<F,T> : INonempySet<F>, INonEmpty<F,T>
        where F : NonempySet<F,T>, new()
    {

    }

    /// <summary>
    /// Characterizes a finite set over elements of parametric type
    /// </summary>
    public interface IElementSet<T> : IDiscreteSet<T>, ICounted
    {
        /// <summary>
        /// Determines whether a value is a member
        /// </summary>
        /// <param name="candidate">The potential member</param>
        bool Contains(T candidate);
    }

    /// <summary>
    /// Characterizes a reified set over elements of parametric type
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="T">The element type</typeparam>
    public interface IElementSet<F,T> : IElementSet<T>, IDiscreteSet<F,T>
        where F : IElementSet<F,T>, new()
    {
        /// <summary>
        /// Determines whether the current set is a subset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate superset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        bool IsSubset(F rhs, bool proper = true);
        
        /// <summary>
        /// Determines whether the current set is a superset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate subset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        bool IsSuperset(F rhs, bool proper = true);

        /// <summary>
        /// Calculates the union between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to union/param>
        F Union(F rhs);
        
        /// <summary>
        /// Calculates the intersection between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to intersect</param>
        F Intersect(F rhs);
        
        /// <summary>
        /// Calculates the set difference, or symmetric difference, between the current 
        /// set and a specified set and returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set that should be differenced</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Symmetric_difference</remarks>
        F Difference(F rhs, bool symmetric = false);
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
        ulong ITypeNat.NatValue 
            => default(N).NatValue;
    }

    public interface IDataIndex<T> : ILengthwise
    {
        T Lookup(int index);
    }

    public interface IIndex<T> : IDataIndex<T>
    {
        ref T this[int index] {get;}  

        T IDataIndex<T>.Lookup(int index) => this[index];
    }

    public interface IIndex<F,T> : IIndex<T>, IReified<F>
        where F : IIndex<F,T>, new()
    {

    }

    /// <summary>
    /// Characterizes a reified immutable T-data index
    /// </summary>
    public interface IReadOnlyIndex<T> : IDataIndex<T>
    {
        ref readonly T this[int index] {get;}

        T IDataIndex<T>.Lookup(int index) => this[index];
    }

    public interface IReadOnlyIndex<F,T> : IReadOnlyIndex<T>, IReified<F>
        where F : IReadOnlyIndex<F,T>, new()
    {

    }

    /// <summary>
    /// Characterizes a finite container over sequentially-indexed discrete content - an array
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IIndexedElements<T> : IContented<T[]>, IEnumerable<T>, IDataIndex<T>
    {
        IEnumerator IEnumerable.GetEnumerator()
            => Content.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Content.ToList().GetEnumerator();

        int ILengthwise.Length
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }
        
        /// <summary>
        /// Retrieves a mutable reference to an index-identified item
        /// </summary>
        ref T this[int index]
        {         
            [MethodImpl(Inline)]
            get => ref Content[index];
        }

        T IDataIndex<T>.Lookup(int index) => this[index];        
    }


    public interface ISeq<T> : IElements<T>
    {        

    }

    /// <summary>
    /// Characterizes a concatenable container with discrete content 
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface ISeq<S,T> : ISeq<T>, IElements<S,T>, IConcatenable<S>
        where S : ISeq<S,T>, new()
    {
        S IConcatenable<S>.Concat(S rhs)
            => WithContent(Content.Concat(rhs.Content));
    }

    /// <summary>
    /// Characterizes an element sequence that is known to be finite, but may require enumeration
    /// to find the count; consequently, there is a "Count()" operation defined but no
    /// "Counted" property
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IFiniteSeq<T> : ISeq<T>, IFinite
    {
        int IFinite.Count() => Content.Count();
    }

    public interface IFiniteSeq<F,T> :  IFiniteSeq<T>, ISeq<F,T>
        where F : IFiniteSeq<F,T>, new()         
    {        
    
    }

    /// <summary>
    /// Characterizes a reifed indexed sequence
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    /// <typeparam name="T">The sequence element type</typeparam>
    public interface IIndexedSeq<S,T> : ISeq<S,T>, IIndex<S,T>
        where S : IIndexedSeq<S,T>, new()
    {
        
    }
}