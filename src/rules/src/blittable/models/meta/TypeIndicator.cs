//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct TypeIndicator
    {
        public AsciSymbol Symbol {get;}

        [MethodImpl(Inline)]
        internal TypeIndicator(AsciSymbol symbol)
        {
            Symbol = symbol;
        }
    }
}