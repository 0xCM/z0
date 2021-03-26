//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Sym<K> : ITextual
        where K : unmanaged
    {
        public SymKey Key {get;}

        public Identifier Name {get;}

        public K Value {get;}

        public SymExpr Symbol {get;}

        [MethodImpl(Inline)]
        internal Sym(uint index, SymbolicLiteral<K> literal)
        {
            Key = index;
            Value = literal.DirectValue;
            Name = literal.Name;
            Symbol = literal.Symbol;
        }

        [MethodImpl(Inline)]
        internal Sym(uint index, string name, K value, string symbol)
        {
            Key = index;
            Name = name;
            Value = value;
            Symbol = symbol;
        }

        public string Format()
            => string.Format("{0}:{1}", Name, Value);

        public override string ToString()
            => Format();
    }
}