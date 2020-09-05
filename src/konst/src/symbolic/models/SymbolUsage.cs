//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SymbolUsage<S>
    {
        public readonly S Symbol;

        public readonly bool Terminal;

        [MethodImpl(Inline)]
        public SymbolUsage(S symbol, bool terminal)
        {
            Symbol = symbol;
            Terminal = terminal;
        }
    }
}