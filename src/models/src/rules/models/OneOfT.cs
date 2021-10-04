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
        /// Specifies that the occurence of an element is distinguished by membership in a specified set
        /// </summary>
        public readonly struct OneOf<T> : ITerm
        {
            readonly Index<T> _Terms;

            [MethodImpl(Inline)]
            public OneOf(Index<T> choices)
                => _Terms = choices;

            public uint Count
            {
                [MethodImpl(Inline)]
                get => _Terms.Count;
            }

            public Span<T> Terms
            {
                [MethodImpl(Inline)]
                get => _Terms;
            }

             public string Format()
                => api.format(this);

             public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator OneOf<T>(T[] src)
                => new OneOf<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator OneOf(OneOf<T> src)
                => new OneOf(src._Terms.Select(x => (dynamic)x));
        }
    }
}