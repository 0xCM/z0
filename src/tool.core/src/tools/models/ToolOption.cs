//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ToolOption
    {
        [MethodImpl(Inline)]
        public static implicit operator ToolOption((string name, string value) src)
            => new ToolOption(src.name, src.value);
        
        [MethodImpl(Inline)]
        public ToolOption(string name, string value)
        {
            Name = name;
            Value = value;
        }
        
        /// <summary>
        /// The option name
        /// </summary>
        public readonly StringRef Name;

        /// <summary>
        /// The option value
        /// </summary>
        public readonly StringRef Value;

        [MethodImpl(Inline)]
        public string Format(string pattern)
            => text.format(pattern, Name.Format(), Value.Format());
        
        [MethodImpl(Inline)]
        public string Format()
            => Format("{0}={1}");

        public override string ToString() 
            => Format();
    }
}