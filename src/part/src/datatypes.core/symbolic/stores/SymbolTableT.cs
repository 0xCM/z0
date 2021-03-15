//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    public class SymbolTable<T>
        where T : unmanaged
    {
        readonly Index<Token<T>> Data;

        readonly Dictionary<string,Token<T>> Identifiers;

        readonly Dictionary<string,Token<T>> Symbols;

        internal SymbolTable(Index<Token<T>> src, Dictionary<string,Token<T>> identifiers, Dictionary<string,Token<T>> symbols)
        {
            Data = src;
            Identifiers = identifiers;
            Symbols = symbols;
        }

        [MethodImpl(Inline)]
        public bool ContainsSymbol(string symbol)
            => Symbols.ContainsKey(symbol);

        [MethodImpl(Inline)]
        public bool ContainsIdentifier(string identifier)
            => Identifiers.ContainsKey(identifier);

        [MethodImpl(Inline)]
        public bool IndexFromSymbol(string symbol, out uint index)
        {
            if(Symbols.TryGetValue(symbol, out var token))
            {
                index = token.Index;
                return true;
            }
            index = uint.MaxValue;
            return false;
        }

        [MethodImpl(Inline)]
        public bool IndexFromIdentifier(string identifier, out uint index)
        {
            if(Identifiers.TryGetValue(identifier, out var token))
            {
                index = token.Index;
                return true;
            }
            index = uint.MaxValue;
            return false;
        }

        [MethodImpl(Inline)]
        public bool TokenFromSymbol(string symbol, out Token<T> dst)
            => Symbols.TryGetValue(symbol, out dst);

        [MethodImpl(Inline)]
        public bool TokenFromIdentifier(string identifier, out Token<T> dst)
            => Identifiers.TryGetValue(identifier, out dst);

        [MethodImpl(Inline)]
        public ref readonly Token<T> TokenFromIndex(uint index)
            => ref Data[index];

        public Index<Token<T>> Tokens
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public uint TokenCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ReadOnlySpan<string> SymbolList
        {
            [MethodImpl(Inline)]
            get => Symbols.Keys.Array();
        }

        public ReadOnlySpan<string> IdentifierList
        {
            [MethodImpl(Inline)]
            get => Identifiers.Keys.Array();
        }
    }
}