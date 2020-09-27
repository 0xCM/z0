//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolSetting<K,V>
        where K : unmanaged
    {
        public K Name {get;}

        public V Value {get;}

        [MethodImpl(Inline)]
        public ToolSetting(K key, V value)
        {
            Name = key;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolSetting<K,V>((K key, V value) src)
            => new ToolSetting<K, V>(src.key, src.value);
    }
}