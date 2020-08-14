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
    /// Defines a value-parametric application setting
    /// </summary>
    public readonly struct AppSetting<T>
    {        
        /// <summary>
        /// The setting name
        /// </summary>
        public readonly StringRef Name;

        /// <summary>
        /// The setting value
        /// </summary>
        public readonly T Value;

        [MethodImpl(Inline)]
        public static implicit operator AppSetting(AppSetting<T> src)
            => src.NonGeneric;

        [MethodImpl(Inline)]
        public AppSetting(in StringRef name, T value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public AppSetting(string name, T value)
        {
            Name = name;
            Value = value;
        }

        public AppSetting NonGeneric
        {
            [MethodImpl(Inline)]
            get => new AppSetting(Name, Value.ToString());
        }
                
        public string Format()
            => Format(false);
        
        public string Format(bool json)
            => json ? text.format(FormatLiterals.JsonProp, Name.Format(), Value) : text.format(Value);
        
        public override string ToString()
            => Format();
    }
}