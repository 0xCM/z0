//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        /// <summary>
        /// Defines a rule r:seq[T] -> seq[T] that defines a sequence element that, if found, is replaced with another
        /// </summary>
        public readonly struct Replace<T>
        {
            /// <summary>
            /// The sequence term to match
            /// </summary>
            public readonly T Match;

            /// <summary>
            /// The replacement value when matched
            /// </summary>
            public readonly T With;

            [MethodImpl(Inline)]
            public Replace(T match, T with)
            {
                Match = match;
                With = with;
            }
        }
    }
}