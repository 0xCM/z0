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
    /// Defines an association between an integer in the range [0,0xFF] and unmanaged data of parametric type
    /// </summary>
    public readonly struct HexLookupEntry<K,T>
        where T : struct
        where K : unmanaged, Enum
    {

        public readonly K Key;

        public readonly T Value;

        [MethodImpl(Inline)]
        public static implicit operator HexLookupEntry<K,T>((K k, T value) src)
            => new HexLookupEntry<K,T>(src.k, src.value);

        [MethodImpl(Inline)]
        public HexLookupEntry(K key, T value)
        {
            Key = key;
            Value = value;
        }
    }
}