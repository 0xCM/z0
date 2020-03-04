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
    
    using static Root;

    public interface IAnyFiniteSeq : IContentAggregate
    {
    }

    public interface IAnyFiniteSeq<T> : IAnyFiniteSeq, IContainer<T[]>,  IContentAggregate<T>
    {
        IEnumerable<T> IContentAggregate<T>.Items    
            => Content;

        int Length
            => Content.Length;
    }

    public delegate C AnyFiniteSeqFactory<T,C>(T[] terms)
        where C : IAnyFiniteSeq<C,T>, new();         

    public interface IAnyFiniteSeq<C,T> :  IAnyFiniteSeq<T>, IAny<C>, IContainer<C,T[],T>
        where C : IAnyFiniteSeq<C,T>, new()         
    {
        /// <summary>
        ///  A self-hosted factory
        /// </summary>
        AnyFiniteSeqFactory<T,C> Factory {get;}
        
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
}