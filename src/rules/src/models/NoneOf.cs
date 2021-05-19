//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        /// <summary>
        /// Specifies that the occurence of an element is distinguished by non-membership in a specified set
        /// </summary>
        public readonly struct NoneOf : IRule<NoneOf>
        {
            public Index<dynamic> Elements {get;}

            [MethodImpl(Inline)]
            public NoneOf(Index<dynamic> choices)
                => Elements = choices;
        }

        /// <summary>
        /// Specifies that the occurence of an element is distinguished by non-membership in a specified set
        /// </summary>
        public readonly struct NoneOf<T> : IRule<NoneOf<T>,T>
        {
            public Index<T> Elements {get;}

            [MethodImpl(Inline)]
            public NoneOf(Index<T> choices)
            {
                Elements = choices;
            }

            [MethodImpl(Inline)]
            public static implicit operator NoneOf<T>(T[] src)
                => new NoneOf<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator NoneOf(NoneOf<T> src)
                => new NoneOf(src.Elements.Select(x => (dynamic)x));
        }
    }
}