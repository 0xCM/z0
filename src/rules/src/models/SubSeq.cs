//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        /// <summary>
        /// Specifies a subsequence search predicate
        /// </summary>
        /// <typeparam name="S">The sequence aggregate type</typeparam>
        /// <typeparam name="T">The sequence element type</typeparam>
        public readonly struct SubSeq<S,T>
            where S : IEquatable<S>
        {
            public S Source {get;}

            public Index<T> Target {get;}

            [MethodImpl(Inline)]
            public SubSeq(S src, Index<T> dst)
            {
                Source = src;
                Target = dst;
            }
        }
    }
}