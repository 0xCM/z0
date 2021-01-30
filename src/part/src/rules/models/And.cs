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
        /// Conjunction
        /// </summary>
        public readonly struct And
        {
            public Index<dynamic> Elements {get;}

            [MethodImpl(Inline)]
            public And(Index<dynamic> src)
            {
                Elements = src;
            }
        }

        /// <summary>
        /// Conjunction
        /// </summary>
        public readonly struct And<T>
        {
            public Index<T> Elements {get;}

            [MethodImpl(Inline)]
            public And(Index<T> src)
            {
                Elements = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator And(And<T> src)
                => new And(src.Elements.Select(x => (dynamic)x));
        }
    }
}