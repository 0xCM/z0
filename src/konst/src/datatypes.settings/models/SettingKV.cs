//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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
    }
}