//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Setting : ITextual
    {
        public string Name {get;}

        public dynamic Value {get;}

        [MethodImpl(Inline)]
        public Setting(string name, dynamic value)
        {
            Name = name ?? EmptyString;
            Value = value ?? EmptyString;
        }

        public string Format(bool json)
            => new SettingValue(Name, Value).Format(json);

        public string Format()
            => Format(true);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Setting((string name, dynamic value) src)
            => new Setting(src.name, src.value);

        public static Setting Empty
        {
            [MethodImpl(Inline)]
            get => new Setting(EmptyString, EmptyString);
        }
    }
}