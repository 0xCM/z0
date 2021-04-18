//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a value-parametric application setting
    /// </summary>
    public readonly struct Setting<T> : ISetting<T>
    {
        /// <summary>
        /// The setting name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The setting value
        /// </summary>
        public T Value {get;}

        [MethodImpl(Inline)]
        public Setting(string name, T value)
        {
            Name = name ?? EmptyString;
            Value = value;
        }

        public SettingValue NonGeneric
        {
            [MethodImpl(Inline)]
            get => new SettingValue(Name, Value.ToString());
        }

        public string Format()
            => text.format(Value);

        public string Json()
            => text.format(RP.JsonProp, Name, Value);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator SettingValue(Setting<T> src)
            => src.NonGeneric;

        [MethodImpl(Inline)]
        public static implicit operator T(Setting<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Setting<T>(T src)
            => new Setting<T>(EmptyString, src);

        [MethodImpl(Inline)]
        public static implicit operator Setting<T>((string name, T value) src)
            => new Setting<T>(src.name, src.value);

        public static Setting<T> Empty
        {
            [MethodImpl(Inline)]
            get => new Setting<T>(String.Empty, root.empty<T>());
        }
    }
}