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
        public readonly struct Marker : IRule<Marker>
        {
            public Index<dynamic> Symbols {get;}

            [MethodImpl(Inline)]
            public Marker(Index<dynamic> symbols)
            {
                Symbols = symbols;
            }
        }

        public readonly struct Marker<T> : IRule<Marker<T>,T>
        {
            public Index<T> Symbols {get;}

            [MethodImpl(Inline)]
            public Marker(Index<T> symbols)
                => Symbols = symbols;
        }
    }
}