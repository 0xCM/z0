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
    /// Characterizes a container that owns content
    /// </summary>
    /// <typeparam name="C">The content type</typeparam>
    public interface IContented<C> : IContainer<C>
    {
        C Content {get;}
    }


    public interface IElements<T> : IContented<IEnumerable<T>>, IEnumerable<T>
    {
        IEnumerator IEnumerable.GetEnumerator()
            => Content.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Content.ToList().GetEnumerator();
    }

    public interface INamedContent<C> : IContented<C>, INamed
    {

    }

    public interface IDescribedContent<C> : IContented<C>, IDescribed
    {

    }

    public interface ILabeledContent<C> : IContented<C>, ILabeled
    {

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
    /// Characterizes a reversible structure
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IReversible<F,T>
        where F : IReversible<F,T>, new()
    {
        F Reverse();
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
    /// Characterizes a finite thing that yeilds a count value that does not require computation/enumeration 
    /// to reveal; in other words, the count function for counted things is free, as evinced by
    /// the default implementation
    /// </summary>
    public interface ICounted : IFinite, INullity
    {
        /// <summary>
        /// The count value
        /// </summary>
        new int Count {get;}

        [MethodImpl(Inline)]
        int IFinite.Count() 
            => Count;

        bool INullity.IsEmpty 
        {
            [MethodImpl(Inline)]
            get => Count == 0;
        }
    }

    /// <summary>
    /// Characterizes a type that exhibits a notion of finite length
    /// </summary>
    public interface IMeasured : ICounted
    {
        int Length {get;}

        int ICounted.Count 
            => Length;
    }

    /// <summary>
    /// Characterizes a refiied type that  exhibits a notion of length
    /// </summary>
    public interface IMeasured<S> : IMeasured, IReified<S>
        where S : IMeasured<S>, new()
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

    /// <summary>
    /// Characterizes a container over discrete/enumerable content which need not be finite
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IDeferred<T> : IContented<IEnumerable<T>>, IEnumerable<T>
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
    public interface IDeferred<F,T> : IDeferred<T>, IContented<F,IEnumerable<T>,T>, IReified<F>, IConcatenable<F,T>
        where F : IDeferred<F,T>, new()
    {
        F IConcatenable<F,T>.Concat(F rhs)
            => WithContent(Content.Concat(rhs.Content));        
    }

    /// <summary>
    /// Characterizes a finite deferred T-sequence
    /// </summary>
    /// <typeparam name="T">The sequence element type</typeparam>
    public interface IFiniteDeferral<T> : IDeferred<T>, IFinite
    {       
        /// <summary>
        /// Brings the deferral to life
        /// </summary>
        T[] Force() 
            => Content.ToArray();
    }

    /// <summary>
    /// Characterizes a reifed finite sequence
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    /// <typeparam name="T">The sequence element type</typeparam>
    public interface IFiniteDeferral<F,T> : IDeferred<F,T>, IFiniteDeferral<T>
        where F : IFiniteDeferral<F,T>, new()   
    {        
            
    }

    public interface IMaterialied<T> : IFinite, IContented<T>, IIndex<T> 
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
    /// Characterizes a reified nonempty set
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    public interface INonempySet<F> : INonEmpty<F>
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
    /// Characterizes a reified set over elements of parametric type
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="T">The element type</typeparam>
    public interface IDeferredSet<F,T> : IFiniteDeferral<F,T>, ICounted, INullity
        where F : IDeferredSet<F,T>, new()
    {
        /// <summary>
        /// Determines whether a value is a member
        /// </summary>
        /// <param name="candidate">The potential member</param>
        bool Contains(T candidate);

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
    public interface IPositional
    {
        /// <summary>
        /// The 0-based position of the item in an enclosing container
        /// </summary>
        int Position {get;}
    }

    public interface IPositional<F> : IPositional, IReified<F>
        where F : IPositional<F>, new()
    {
        
    }

    public interface IDataIndex<T> : IMeasured
    {
    
    }

    public interface IReadOnlyIndex<T> : IDataIndex<T>
    {
        ref readonly T this[int index] {get;}  

        ref readonly T Lookup(int index) 
            => ref this[index];    
    }

    /// <summary>
    /// Characterizes a finite container over sequentially-indexed discrete content - an array
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IIndex<T> : IContented<T[]>, IMeasured, IEnumerable<T>
    {
        IEnumerator IEnumerable.GetEnumerator()
            => Content.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Content.ToList().GetEnumerator();

        int IMeasured.Length
            => Content?.Length ?? 0;

        ref T this[int index]
            => ref Content[index];

        ref T Lookup(int index) 
            => ref this[index];
    }
    
    public interface IIndex<F,T> : IIndex<T>, IReified<F>, INullary<F,T>
        where F : IIndex<F,T>, new()
    {
        bool INullity.IsEmpty 
            => Content?.Length == 0;
    }

    public interface INonEmptyIndex<T> : IIndex<T>
    {
        ref T Head {get;}

        ref T Tail {get;}
    }

    /// <summary>
    /// Characterizes a reifed finite indexed sequence
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    /// <typeparam name="T">The sequence element type</typeparam>
    public interface IIndexedSeq<F,T> : INonEmptyIndex<T>, IReversible<F,T> 
        where F : IIndexedSeq<F,T>, new()
    {

    }
    
    public interface IListed<T> : IMeasured
    {
        /// <summary>
        /// Returns the first constituent if extant; othewise, returns the monoidal 0
        /// </summary>
        T Head {get;}

        /// <summary>
        /// Returns the last constituent if extant; othewise, returns the monoidal 0
        /// </summary>
        T Tail {get;}
    }

    public interface IListed<S,T> : IListed<T>, IReversible<S,T> 
        where S : IListed<S,T>, new()
    {

    }

    public interface IDecrementable<S> : IOrdered<S>
        where S : IDecrementable<S>, new()
    {
        S Dec();
    }

    public interface IIncrementable<S> : IOrdered<S>
        where S : IIncrementable<S>, new()
    {
        S Inc();        
    }

    /// <summary>
    /// Characterizes a structure over which both incrementing and decrementing 
    /// operations are defined
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    public interface IStepwise<S> : IIncrementable<S>, IDecrementable<S>
        where S : IStepwise<S>, new()
    {

    }        
}