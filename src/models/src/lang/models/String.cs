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
    public readonly struct String<K>
        where K : unmanaged
    {
        readonly Index<Symbol<K>> Data;

        [MethodImpl(Inline)]
        public String(Symbol<K>[] value)
        {
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

        public static implicit operator String<K>(Symbol<K>[] src)
            => new String<K>(src);
    }
}