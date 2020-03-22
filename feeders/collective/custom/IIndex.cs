//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Collective;
    
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
    /// Characterizes a container I with mutable content such that: 
    /// - I has a capacity of n items where n is determined when a reification 
    /// is instantiated and remains fixed throught its lifetime
    /// - I maintaines A bijection between the integers {0,.., n-1} and the contained elements 
    /// that also remains fixed
    /// </summary>
    public interface IIndex<T> : IReadOnlyIndex<T>
    {
        new ref T this[int index] {get;}

        ref readonly T IReadOnlyIndex<T>.this[int index] 
        {
            [MethodImpl(Inline)]   
            get => ref this[index];
        }
    }

    public static class Index
    {
        
    }
}