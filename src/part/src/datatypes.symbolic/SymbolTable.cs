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
        public bool Contains(Identifier symbol)
            => Keys.ContainsKey(symbol);

        [MethodImpl(Inline)]
        public bool Index(Identifier symbol, out uint index)
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

        public uint TokenCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
    }
    // public class SymbolTable<T>
    // {
    //     readonly Index<T> Data;

    //     readonly Dictionary<string, Paired<uint,T>> Keys;

    //     internal SymbolTable(Index<T> src, Dictionary<string,Paired<uint,T>> keys)
    //     {
    //         Data = src;
    //         Keys = keys;
    //     }

    //     [MethodImpl(Inline)]
    //     public bool Contains(Name symbol)
    //         => Keys.ContainsKey(symbol);

    //     [MethodImpl(Inline)]
    //     public bool Index(Name symbol, out uint index)
    //     {
    //         if(Keys.TryGetValue(symbol, out var pair))
    //         {
    //             index = pair.Left;
    //             return true;
    //         }
    //         index = uint.MaxValue;
    //         return false;
    //     }

    //     [MethodImpl(Inline)]
    //     public ref readonly T Entry(uint index)
    //         => ref Data[index];

    //     public ReadOnlySpan<T> Entries
    //     {
    //         [MethodImpl(Inline)]
    //         get => Data.View;
    //     }

    //     public uint EntryCount
    //     {
    //         [MethodImpl(Inline)]
    //         get => Data.Count;
    //     }
    // }
}