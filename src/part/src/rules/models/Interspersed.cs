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
        /// Represents the consequence of <see cref='Intersperse{T}'/> rule application
        /// </summary>
        public readonly struct Interspersed<T>
        {
            /// <summary>
            /// The interspersed terms
            /// </summary>
            public Index<T> Terms {get;}

            /// <summary>
            /// The interspersal rule
            /// </summary>
            public Intersperse<T> Rule {get;}

            [MethodImpl(Inline)]
            public Interspersed(Index<T> terms, Intersperse<T> rule)
            {
                Terms = terms;
                Rule = rule;
            }
        }
    }
}