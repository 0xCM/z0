//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a sequence of umanaged values indexed by an integer in the range [0,255]
    /// </summary>
    public readonly struct HexLookup<K,T> : IHexLookup<K,T>
        where K : unmanaged, Enum
    {
        public readonly T[] Values;

        [MethodImpl(Inline)]
        public HexLookup(T[] src)
        {
            Values = src;
        }

        [MethodImpl(Inline)]
        public ref readonly T Lookup(K key)
            => ref Values[EnumValue.e8u(key)];

        public ref readonly T this[K index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Values.Length;
        }

        public ref readonly T this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(EnumValue.literal<K>((byte)index));
        }
    }
}