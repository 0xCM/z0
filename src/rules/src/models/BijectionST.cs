//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Rules
    {
        /// <summary>
        /// Represents a bijective correspondence between two sequences
        /// </summary>
        public readonly struct Bijection<S,T>
        {
            public Index<S> Source {get;}

            public Index<T> Target {get;}

            [MethodImpl(Inline)]
            public Bijection(Index<S> src, Index<T> dst)
            {
                Source = src;
                Target = dst;
            }

            public Paired<S,T> this[uint i]
            {
                [MethodImpl(Inline)]
                get => (Source[i], Target[i]);
            }
        }
    }
}