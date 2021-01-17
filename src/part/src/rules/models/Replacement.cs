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
        /// Defines a rule r:seq[T] -> seq[T] that requires a specified sequence element, if found, is replaced with another
        /// </summary>
        public readonly struct Replacement<T>
        {
            /// <summary>
            /// The sequence term to match
            /// </summary>
            public T Match {get;}

            /// <summary>
            /// The replacement value when matched
            /// </summary>
            public T Replace {get;}

            [MethodImpl(Inline)]
            public Replacement(T match, T replace)
            {
                Match = match;
                Replace = replace;
            }
        }
    }
}