//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed;

    /// <summary>
    /// Defines a value-parametric application setting
    /// </summary>
    public readonly struct AppSetting<T> : IAppSetting<T>, ITextual<AppSetting<T>, AppSettingFormat> 
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
        public string Format(AppSettingFormat config)
            => NonGeneric.Format(config);
        
        public string Format()
            => NonGeneric.Format();
        
        public override string ToString()
            => NonGeneric.ToString();
    }
}