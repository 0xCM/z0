//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct TokenSpec<K,S>
        where K : unmanaged
        where S : unmanaged, ISymbol<S>
    {
        public readonly Sequential Index;

        public readonly Kind<K> Kind;

        public asci16 Identifier;

        public Symbols<S> Symbols;

        [MethodImpl(Inline)]
        public TokenSpec(uint index, K kind, string id, S[] symbols)
        {
            Kind = kind;
            Index = index;
            Identifier = id;
            Symbols = symbols;
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

        public uint4 Length
        {
            [MethodImpl(Inline)]
            get => (byte)Symbols.Count;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(Index, Kind, Identifier);
    }
}