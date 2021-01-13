//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

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
                Demands.insist(src != null && dst != null && src.Length == dst.Length);
                Source = src;
                Target = dst;
            }

            public Paired<S,T> this[uint i]
            {
                [MethodImpl(Inline)]
                get => paired(skip(Source,i), skip(Target,i));
            }
        }
    }
}