//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed;
    using static AppSetting;

    public readonly struct AppSetting : IFormattable<AppSetting, FormatConfig>, IAppSetting
    {
        public readonly struct FormatConfig
        {
            public static FormatConfig Default => new FormatConfig(true);

            [MethodImpl(Inline)]
            public FormatConfig(bool json)
            {
                FormatAsJson = json;
            }

            public bool FormatAsJson {get;}
        }

        public string Name {get;}        

        public string Value {get;}

        [MethodImpl(Inline)]
        public AppSetting(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        public string Format(FormatConfig config)
        {
            if(config.FormatAsJson)
                return string.Concat(Name.Enquote(), Chars.Colon, Chars.Space, Value.Enquote());
            else 
                return $"{Name}: {Value}";
        }        

        public string Format()
            => Format(new FormatConfig(true));

        
        public override string ToString()
            => Format(new FormatConfig(false));
    }

    public readonly struct AppSetting<T> : IFormattable<AppSetting<T>,FormatConfig>
    {        
        public string Name {get;}        

        public T Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator AppSetting(AppSetting<T> src)
            => src.NonGeneric;
         
        [MethodImpl(Inline)]
        public AppSetting(string name, T value)
        {
            this.Name = name;
            this.Value = value;
        }

        AppSetting NonGeneric
        {
            [MethodImpl(Inline)]
            get => new AppSetting(Name, Value.ToString());
        }

        [MethodImpl(Inline)]
        public AppSetting ToNonGeneric()
            => NonGeneric;

        [MethodImpl(Inline)]
        public string Format(FormatConfig config)
            => NonGeneric.Format(config);
        
        public string Format()
            => NonGeneric.Format();
        
        public override string ToString()
            => NonGeneric.ToString();
    }
}