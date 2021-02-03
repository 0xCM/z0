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
        /// Specifies that the occurence of an element is distinguished by membership in a specified set
        /// </summary>
        public readonly struct OneOf : IRule<OneOf>
        {
            public Index<dynamic> Elements {get;}

            [MethodImpl(Inline)]
            public OneOf(Index<dynamic> choices)
                => Elements = choices;

            public uint Count
            {
                [MethodImpl(Inline)]
                get => Elements.Count;
            }
        }

        /// <summary>
        /// Specifies that the occurence of an element is distinguished by membership in a specified set
        /// </summary>
        public readonly struct OneOf<T> : IRule<OneOf<T>,T>
        {
            public Index<T> Elements {get;}

            [MethodImpl(Inline)]
            public OneOf(Index<T> choices)
                => Elements = choices;

            public uint Count
            {
                [MethodImpl(Inline)]
                get => Elements.Count;
            }

            [MethodImpl(Inline)]
            public static implicit operator OneOf<T>(T[] src)
                => new OneOf<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator OneOf(OneOf<T> src)
                => new OneOf(src.Elements.Select(x => (dynamic)x));
        }
    }
}