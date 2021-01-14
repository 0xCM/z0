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

            public Bijection(S[] src, T[] dst)
            {
                root.require(src != null && dst != null && src.Length == dst.Length, () => "bad");
                Source = src;
                Target = dst;
            }

            public Paired<S,T> this[uint i]
            {
                [MethodImpl(Inline)]
                get => root.paired(skip(Source,i), skip(Target,i));
            }
        }
    }
}