//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SymbolicLiteral<S>
        where S : unmanaged
    {
        public Symbol<S> Symbol {get;}

        public Identifier Kind {get;}

        public SymbolName<S> Name {get;}

        public TextBlock Description {get;}

        [MethodImpl(Inline)]
        public SymbolicLiteral(Symbol<S> symbol, SymbolName<S> name, Identifier kind, TextBlock description)
        {
            Symbol = symbol;
            Kind = kind;
            Name = name;
            Description = description;
        }
    }
}