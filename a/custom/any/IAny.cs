//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Core;

    /// <summary>
    /// Characterizes any refiication
    /// </summary>
    /// <typeparam name="T">The ensconsed </typeparam>
    public interface IAny<T> : IFormattable<T>, IEquatable<T>
        where T : IAny<T>
    {
        
    }

    public delegate C FiniteSeqFactory<T,C>(T[] terms)
        where C : IFiniteSeq<C,T>, new();         

    public interface IFiniteSeq<C,T> :  IFiniteSeq<T>, IAny<C>, IContainer<C,T[],T>
        where C : IFiniteSeq<C,T>, new()         
    {
        /// <summary>
        ///  A self-hosted factory
        /// </summary>
        FiniteSeqFactory<T,C> Factory {get;}
        
        bool IEquatable<C>.Equals(C src)
            => Enumerable.SequenceEqual(this, src);

        /// <summary>
        /// Creates the empty sequence
        /// </summary>
        public static C Empty => Create(new T[]{});

        /// <summary>
        /// Creates a concrete sequence from a source enumerable
        /// </summary>
        /// <param name="src">The term source</param>
        public static C Create(T[] src) => Empty.Factory(src);
    }

    public interface IFiniteSeq : IContentAggregate
    {
    }

    public interface IFiniteSeq<T> : IFiniteSeq, IContainer<T[]>,  IContentAggregate<T>
    {
        IEnumerable<T> IContentAggregate<T>.Items    
            => Content;

        int Length
            => Content.Length;
        
        T this[int index]
        {
            [MethodImpl(Inline)]
            get => Content[index];
        }
    }


}