//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolSetting
    {
        public ToolSettingKind Name {get;}

        public string Value {get;}

        [MethodImpl(Inline)]
        public ToolSetting(ToolSettingKind name, string value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolSetting((ToolSettingKind key, string value) src)
            => new ToolSetting(src.key, src.value);
    }
}