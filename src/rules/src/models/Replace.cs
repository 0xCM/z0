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
        /// Defines a rule r:seq[T] -> seq[T] that defines a sequence element that, if found, is replaced with another
        /// </summary>
        public readonly struct Replace<T> : IRule<Replace<T>,T>
        {
            /// <summary>
            /// The sequence term to match
            /// </summary>
            public T Match {get;}

            /// <summary>
            /// The replacement value when matched
            /// </summary>
            public T With {get;}

            [MethodImpl(Inline)]
            public Replace(T match, T with)
            {
                Match = match;
                With = with;
            }
        }
    }
}