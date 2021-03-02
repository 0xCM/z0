//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a kinded token
    /// </summary>
    public readonly struct Token<K> : IToken<K>
        where K : unmanaged
    {
        public uint Index {get;}

        public Identifier Name {get;}

        public K Kind {get;}

        public TextBlock Symbol {get;}

        [MethodImpl(Inline)]
        public Token(uint index, Identifier name, K kind, TextBlock symbol)
        {
            Index = index;
            Name = name;
            Kind = kind;
            Symbol = symbol;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Index == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Index != 0;
        }

        public string Format()
            => string.Format("{0,-8} | {1,-12} | {2}", Index, text.ifempty(Name, RP.EmptySymbol), text.ifempty(Symbol, RP.EmptySymbol));

        public override string ToString()
            => Format();

        public static Token<K> Empty => default;
    }
}