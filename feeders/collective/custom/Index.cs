//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Collective;

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

    /// <summary>
    /// A default index implementation
    /// </summary>
    public readonly struct Index<T> : IIndex<T>
    {
        readonly T[] content;

        [MethodImpl(Inline)]
        public Index(T[] content)
        {
            this.content = content;
        }
        
        public ref T this[int index]        
        {
            [MethodImpl(Inline)]
            get => ref content[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => content.Length;
        }
    }

    public readonly struct I0 : IIndexed<I0> { public int Position => 0;}
    
    public readonly struct I1 : IIndexed<I1> { public int Position => 1;}

    public readonly struct I2 : IIndexed<I2> { public int Position => 2;}

    public readonly struct I3 : IIndexed<I3> { public int Position => 3;}

    public readonly struct I4  : IIndexed<I4> { public int Position => 4;}

    public readonly struct I5 : IIndexed<I5> { public int Position => 5;}

    public readonly struct I6  : IIndexed<I6> { public int Position => 6;}

    public static class Index
    {
        

    }

    public static class Indicies
    {
        public static I0 i0 => default;

        public static I1 i1 => default;

        public static I2 i2 => default;

        public static I3 i3 => default;

        public static I4 i4 => default;

        public static I5 i5 => default;

        public static I6 i6 => default;
    }
}