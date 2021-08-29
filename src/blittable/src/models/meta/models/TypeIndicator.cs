//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        public readonly struct TypeIndicator
        {
            public AsciSymbol Symbol {get;}

            [MethodImpl(Inline)]
            internal TypeIndicator(AsciSymbol symbol)
            {
                Symbol = symbol;
            }

            [MethodImpl(Inline)]
            public static implicit operator char(TypeIndicator src)
                => src.Symbol;
        }
    }
}