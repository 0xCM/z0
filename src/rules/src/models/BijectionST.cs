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
        public readonly ref struct Bijection<S,T>
        {
            public ReadOnlySpan<S> Source {get;}

            public ReadOnlySpan<T> Target {get;}

            [MethodImpl(Inline)]
            public Bijection(ReadOnlySpan<S> src, ReadOnlySpan<T> dst)
            {
                Source = src;
                Target = dst;
            }

            public Paired<S,T> this[uint i]
            {
                [MethodImpl(Inline)]
                get => (skip(Source,i), skip(Target,i));
            }
        }
    }
}