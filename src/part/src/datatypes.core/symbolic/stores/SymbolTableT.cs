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

    public struct SymbolTable<T>
        where T : unmanaged
    {
        readonly Index<Token<T>> _Tokens;

        readonly Dictionary<string,Token<T>> _Identifiers;

        readonly Dictionary<string,Token<T>> _Symbols;

        readonly Index<Sym<T>> _Entries;

        internal SymbolTable(Index<Token<T>> src, Dictionary<string,Token<T>> identifiers, Dictionary<string,Token<T>> symbols)
        {
            var count = src.Count;
            _Tokens = src;
            _Identifiers = identifiers;
            _Symbols = symbols;
            _Entries = memory.alloc<Sym<T>>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var token = ref _Tokens[i];
                _Entries[i] = new Sym<T>(i, token.Identifier, token.Kind, token.SymbolName.SymbolText.Format());
            }
        }

        public ref readonly Sym<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref _Entries[index];
        }

        [MethodImpl(Inline)]
        public bool ContainsSymbol(string symbol)
            => _Symbols.ContainsKey(symbol);

        [MethodImpl(Inline)]
        public bool ContainsIdentifier(string identifier)
            => _Identifiers.ContainsKey(identifier);

        [MethodImpl(Inline)]
        public bool IndexFromSymbol(string symbol, out uint index)
        {
            if(_Symbols.TryGetValue(symbol, out var token))
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
            if(_Identifiers.TryGetValue(identifier, out var token))
            {
                index = token.Index;
                return true;
            }
            index = uint.MaxValue;
            return false;
        }

        [MethodImpl(Inline)]
        public bool TokenFromSymbol(string symbol, out Token<T> dst)
            => _Symbols.TryGetValue(symbol, out dst);

        [MethodImpl(Inline)]
        public bool TokenFromIdentifier(string identifier, out Token<T> dst)
            => _Identifiers.TryGetValue(identifier, out dst);

        [MethodImpl(Inline)]
        public ref readonly Token<T> TokenFromIndex(uint index)
            => ref _Tokens[index];

        public Index<Token<T>> Tokens
        {
            [MethodImpl(Inline)]
            get => _Tokens;
        }

        public uint TokenCount
        {
            [MethodImpl(Inline)]
            get => _Tokens.Count;
        }

        public ReadOnlySpan<Sym<T>> Symbols
        {
            [MethodImpl(Inline)]
            get => _Entries.View;
        }
    }
}