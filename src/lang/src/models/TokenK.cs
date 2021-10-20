//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// The textbook definition of a string - a finite sequence of symbols
    /// </summary>
    public readonly struct Token<K>
        where K : unmanaged
    {
        public uint Key {get;}

        readonly Index<Symbol<K>> Data;

        [MethodImpl(Inline)]
        public Token(uint key, Symbol<K>[] value)
        {
            Key = key;
            Data = value;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsNonEmpty;
        }

        public ref Symbol<K> this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public ref Symbol<K> this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }        
    }    
}