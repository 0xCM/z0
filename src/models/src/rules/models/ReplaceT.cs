//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Rules;

    partial struct Rules
    {
        /// <summary>
        /// Defines a rule r:seq[T] -> seq[T] that defines a sequence element that, if found, is replaced with another
        /// </summary>
        public readonly struct Replace<T> : ITerm<T>
        {
            /// <summary>
            /// The sequence term to match
            /// </summary>
            public readonly T Match;

            /// <summary>
            /// The replacement value when matched
            /// </summary>
            public T Value {get;}

            [MethodImpl(Inline)]
            public Replace(T match, T value)
            {
                Match = match;
                Value = value;
            }

            public string Format()
                => api.format(this);

            public override string ToString()
                => Format();
        }
    }
}