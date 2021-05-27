//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using api = Settings;

    /// <summary>
    /// Defines a nonparametric kvp application setting
    /// </summary>
    public readonly struct SettingValue : ISetting
    {
        /// <summary>
        /// The setting name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The setting value
        /// </summary>
        public dynamic Value {get;}

        [MethodImpl(Inline)]
        public SettingValue(string name, dynamic value)
        {
            Name = name;
            Value = value;
        }

        public string Format(bool json)
            => api.format(this, json);

        public string Format()
            => Format(false);


        public override string ToString()
            => Format();
    }
}