//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CmdSetting<V>
    {
        public string Name {get;}

        public V Value {get;}

        [MethodImpl(Inline)]
        public CmdSetting(string key, V value)
        {
            Name = key;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdSetting<V>((string key, V value) src)
            => new CmdSetting<V>(src.key, src.value);
    }
}