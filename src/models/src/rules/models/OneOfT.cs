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
        public readonly struct OneOf<T> : IOneOf<T>
        {
            readonly Index<T> _Choices;

            [MethodImpl(Inline)]
            public OneOf(Index<T> choices)
                => _Choices = choices;

            public uint Count
            {
                [MethodImpl(Inline)]
                get => _Choices.Count;
            }

            public Span<T> Choices
            {
                [MethodImpl(Inline)]
                get => _Choices;
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
                => new OneOf(src._Choices.Select(x => (dynamic)x));
        }
    }
}