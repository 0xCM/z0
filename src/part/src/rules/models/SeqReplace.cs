//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        /// <summary>
        /// Defines a rule r:seq[T] -> seq[T] that requires a specified subsequence, if found, to be replaced with another
        /// </summary>
        public readonly struct SeqReplace<T> : IRule<SeqReplace<T>>
        {
            /// <summary>
            /// The sequence term to match
            /// </summary>
            public T[] Match {get;}

            /// <summary>
            /// The replacement value when matched
            /// </summary>
            public T[] With {get;}

            [MethodImpl(Inline)]
            public SeqReplace(T[] match, T[] with)
            {
                Match = match;
                With = with;
            }

            [MethodImpl(Inline)]
            public static implicit operator SeqReplace<T>((T[] match, T[] with) src)
                => new SeqReplace<T>(src.match, src.with);
        }
    }
}