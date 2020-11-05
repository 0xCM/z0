//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CmdSetting
    {
        public string Name {get;}

        public string Value {get;}

        [MethodImpl(Inline)]
        public CmdSetting(string name, string value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdSetting((string key, string value) src)
            => new CmdSetting(src.key, src.value);
    }
}