//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
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
                Source = src;
                Target = dst;
            }

            public Pair<T> this[uint i]
            {
                [MethodImpl(Inline)]
                get => (Source[i], Target[i]);
            }
        }
    }
}