//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Setting<K,V> : ISetting<Setting<K,V>,K,V>
    {
        public K Name {get;}

        public V Value {get;}

        [MethodImpl(Inline)]
        public Setting(K name, V value)
        {
            Name = name;
            Value = value;
        }

        public static implicit operator Setting<K,V>((K key, V value) src)
            => new Setting<K,V>(src.key, src.value);
    }
}