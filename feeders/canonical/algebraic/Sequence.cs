//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

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

    /// <summary>
    /// Characterizes a mathematical sequence that carries an integer to a term and may be empty, finite or infinite
    /// </summary>
    /// <typeparam name="I">The sequence domain</typeparam>
    /// <typeparam name="T">The sequence codomain</typeparam>
    public interface ISequence<I,T> : IConcrete<I>
        where I : ISequence<I,T>, new()
    {
        /// <summary>
        /// Yields 0 or more terms t(0), t(1),... of the sequence, contingent upon
        /// both demand and availability
        /// </summary>
        IEnumerable<KeyedValue<I,T>> Terms();
    }

    /// <summary>
    /// Characterizes a sequence that has at least one term
    /// </summary>
    /// <typeparam name="I">The sequence domain</typeparam>
    /// <typeparam name="T">The sequence codomain</typeparam>
    public interface INonemptySequence<I,T> : ISequence<I,T>
        where I : INonemptySequence<I,T>, new()
    {
        /// <summary>
        /// The first element of the sequence
        /// </summary>
        KeyedValue<I,T> Head {get;}

        /// <summary>
        /// All elements of the sequence except the first
        /// </summary>
        /// <value></value>
        ISequence<I,T> Tail {get;}
    }

    /// <summary>
    /// Characterizes an infinite sequence
    /// </summary>
    /// <typeparam name="I">The sequence domain</typeparam>
    /// <typeparam name="T">The sequence codomain</typeparam>
    public interface IInfiniteSequence<I,T> : INonemptySequence<I,T>
        where I : IInfiniteSequence<I,T>, new()
    {

    }
}