//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SymbolEntry<K> : ITextual
        where K : unmanaged
    {
        public uint Index {get;}

        public Identifier Name {get;}

        public K Value {get;}

        public string Symbol {get;}

        [MethodImpl(Inline)]
        internal SymbolEntry(uint index, SymbolicLiteral<K> literal)
        {
            Index = index;
            Value = literal.DirectValue;
            Name = literal.Name;
            Symbol = literal.Symbol;
        }

        [MethodImpl(Inline)]
        internal SymbolEntry(uint index, string name, K value, string symbol)
        {
            Index = index;
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