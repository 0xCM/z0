//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ToolOption<K,V>
        where K : unmanaged
    {
        /// <summary>
        /// The option name
        /// </summary>
        public K Key {get;}

        /// <summary>
        /// The option value
        /// </summary>
        public V Value {get;}

        [MethodImpl(Inline)]
        public ToolOption(K name, V value)
        {
            Key = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolOption<K,V>((K key, V value) src)
            => new ToolOption<K,V>(src.key, src.value);

        [MethodImpl(Inline)]
        public static implicit operator ToolOption(ToolOption<K,V> src)
            => new ToolOption(src.Key.ToString(), src.Value?.ToString() ?? EmptyString);
    }
}