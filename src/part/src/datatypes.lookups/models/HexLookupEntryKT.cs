//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines an association between an integer in the range [0,0xFF] and unmanaged data of parametric type
    /// </summary>
    public readonly struct HexLookupEntry<K,T>
        where K : unmanaged
        where T : struct
    {
        public K Key {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public HexLookupEntry(K key, T value)
        {
            Key = key;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator HexLookupEntry<K,T>((K k, T value) src)
            => new HexLookupEntry<K,T>(src.k, src.value);
    }
}