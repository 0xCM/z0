//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public readonly struct AppPathSetting : ITextual  
    {
        public readonly StringRef Name;

        public readonly StringRef Value;

        [MethodImpl(Inline)]
        public static implicit operator AppSetting<StringRef>(AppPathSetting src)
            => new AppSetting<StringRef>(src.Name, src.Value);
        
        [MethodImpl(Inline)]
        public AppPathSetting(string name, string value)
        {
            Name = name;
            Value = value;
        }        

        [MethodImpl(Inline)]
        public string Format(bool json)
            => json ? text.format(FormatLiterals.JsonProp, Name, Value) : Value.Format();

        [MethodImpl(Inline)]
        public string Format()
            => Format(false);        


        public override string ToString()
            => Format();
    }
}