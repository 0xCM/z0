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
        /// Represents a bijective correspondence between two sequences of homogenous type
        /// </summary>
        public readonly ref struct Bijection<T>
        {
            public ReadOnlySpan<T> Source {get;}

            public ReadOnlySpan<T> Target {get;}

            [MethodImpl(Inline)]
            public Bijection(ReadOnlySpan<T> src, ReadOnlySpan<T> dst)
            {
                Source = src;
                Target = dst;
            }

            public Pair<T> this[uint i]
            {
                [MethodImpl(Inline)]
                get => (skip(Source,i), skip(Target,i));
            }
        }
    }
}