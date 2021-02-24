//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines a sequence of unmanaged values indexed by an integer in the range [0,255]
    /// </summary>
    public readonly ref struct HexLookup<K,T>
        where K : unmanaged, Enum
    {
        readonly Span<T> Values;

        [MethodImpl(Inline)]
        internal HexLookup(Span<T> src)
            => Values = src;

        [MethodImpl(Inline)]
        public ref T Lookup(K key)
            => ref seek(Values, u8(key));

        public ref T this[K index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Values.Length;
        }
    }
}