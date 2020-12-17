//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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
        public string Value {get;}

        [MethodImpl(Inline)]
        public SettingValue(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Format(bool json)
        {
            if(json)
                return string.Concat(Name.Enquote(), Chars.Colon, Chars.Space, Value.Enquote());
            else
                return TextFormatter.setting(Name,Value);
        }

        public string Format()
            => Format(true);


        public override string ToString()
            => Format();
    }
}