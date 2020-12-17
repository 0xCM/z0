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
    public readonly struct SettingValue<T>
    {
        /// <summary>
        /// The setting name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The setting value
        /// </summary>
        public readonly T Value;

        [MethodImpl(Inline)]
        public static implicit operator SettingValue(SettingValue<T> src)
            => src.NonGeneric;


        [MethodImpl(Inline)]
        public SettingValue(string name, T value)
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
            => Format(false);

        public string Format(bool json)
            => json ? text.format(RP.JsonProp, Name, Value) : text.format(Value);

        public override string ToString()
            => Format();
    }
}