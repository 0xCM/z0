//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PathSetting : ITextual
    {
        public readonly StringRef Name;

        public readonly StringRef Value;

        [MethodImpl(Inline)]
        public static implicit operator SettingValue<StringRef>(PathSetting src)
            => new SettingValue<StringRef>(src.Name, src.Value);

        [MethodImpl(Inline)]
        public PathSetting(string name, string value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public string Format(bool json)
            => json ? text.format(RP.JsonProp, Name, Value) : Value.Format();

        [MethodImpl(Inline)]
        public string Format()
            => Format(false);


        public override string ToString()
            => Format();
    }
}