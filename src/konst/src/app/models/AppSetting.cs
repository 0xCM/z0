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
    public readonly struct AppSetting : ITextual<AppSetting, AppSettingFormat>, IAppSetting
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
        public AppSetting(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Format(AppSettingFormat config)
        {
            if(config.FormatAsJson)
                return string.Concat(Name.Enquote(), Chars.Colon, Chars.Space, Value.Enquote());
            else 
                return $"{Name}: {Value}";
        }        

        public string Format()
            => Format(new AppSettingFormat(true));

        
        public override string ToString()
            => Format(new AppSettingFormat(false));
    }
}