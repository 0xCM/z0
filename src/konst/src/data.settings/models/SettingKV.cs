//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = Settings;

    public readonly struct Setting<K,V> : ISetting<Setting<K,V>,K,V>
        where K : struct, ISettingKey<K>
        where V : struct, ISettingValue<V>
    {
        public K Name {get;}

        public V Value {get;}

        [MethodImpl(Inline)]
        public Setting(K name, V value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public bool Parse(string src, out Setting<K,V> dst)
            => api.parse(src, out dst);

        [MethodImpl(Inline)]
        public string Format()
            => Render.setting(Name.Format(),Value.Format());
    }
}