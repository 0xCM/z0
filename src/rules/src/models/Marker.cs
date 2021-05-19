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
        public readonly struct Marker : IRule<Marker>
        {
            public dynamic Element {get;}

            [MethodImpl(Inline)]
            public Marker(dynamic src)
            {
                Element = src;
            }
        }

        public readonly struct Marker<T> : IRule<Marker<T>,T>
        {
            public T Element{get;}

            [MethodImpl(Inline)]
            public Marker(T src)
                => Element = src;

            public static implicit operator Marker(Marker<T> src)
                => new Marker(src.Element);

            public static implicit operator Marker<T>(T src)
                => new Marker<T>(src);
        }
    }
}