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
        public readonly struct OneOf
        {
            public Index<dynamic> Choices {get;}

            [MethodImpl(Inline)]
            public OneOf(Index<dynamic> choices)
            {
                Choices = choices;
            }
        }

        public readonly struct OneOf<T>
        {
            public Index<T> Choices {get;}

            [MethodImpl(Inline)]
            public OneOf(Index<T> choices)
            {
                Choices = choices;
            }

            [MethodImpl(Inline)]
            public static implicit operator OneOf<T>(T[] src)
                => new OneOf<T>(src);
        }
    }
}