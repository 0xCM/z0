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

        readonly Dictionary<string,Token<T>> Keys;

        internal SymbolTable(Index<Token<T>> src, Dictionary<string,Token<T>> keys)
        {
            Data = src;
            Keys = keys;
        }

        [MethodImpl(Inline)]
        public bool Contains(TextBlock symbol)
            => Keys.ContainsKey(symbol);

        [MethodImpl(Inline)]
        public bool Index(TextBlock symbol, out uint index)
        {
            if(Keys.TryGetValue(symbol, out var token))
            {
                index = token.Index;
                return true;
            }
            index = uint.MaxValue;
            return false;
        }

        [MethodImpl(Inline)]
        public ref readonly Token<T> Token(uint index)
            => ref Data[index];

        public ReadOnlySpan<Token<T>> Tokens
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Index<string> Symbols
        {
            [MethodImpl(Inline)]
            get => Keys.Keys.Array();
        }

        public uint TokenCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
    }
}