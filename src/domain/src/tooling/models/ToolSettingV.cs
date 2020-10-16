//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolSetting<V>
    {
        public ToolSettingKind Name {get;}

        public V Value {get;}

        [MethodImpl(Inline)]
        public ToolSetting(ToolSettingKind key, V value)
        {
            Name = key;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolSetting<V>((ToolSettingKind key, V value) src)
            => new ToolSetting<V>(src.key, src.value);
    }
}