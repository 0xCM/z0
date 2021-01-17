//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Rules
    {
        /// <summary>
        /// Represents a bijective correspondence between two sequences
        /// </summary>
        public readonly struct Bijection<S,T>
        {
            public S[] Source {get;}

            public T[] Target {get;}

            [MethodImpl(Inline)]
            public Bijection(Index<S> src, Index<T> dst)
            {
                root.require(src.Length == dst.Length, () => "Equality of length there must be");
                Source = src;
                Target = dst;
            }

            public Paired<S,T> this[uint i]
            {
                [MethodImpl(Inline)]
                get => root.paired(skip(Source,i), skip(Target,i));
            }
        }

        /// <summary>
        /// Represents a bijective correspondence between two sequences of homogenous type
        /// </summary>
        public readonly struct Bijection<T>
        {
            public Index<T> Source {get;}

            public Index<T> Target {get;}

            [MethodImpl(Inline)]
            public Bijection(Index<T> src, Index<T> dst)
            {
                root.require(src.Length == dst.Length, () => "Equality of length there must be");
                Source = src;
                Target = dst;
            }

            public Pair<T> this[uint i]
            {
                [MethodImpl(Inline)]
                get => root.pair(Source[i], Target[i]);
            }
        }
    }
}