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
        /// <summary>
        /// The option name
        /// </summary>
        public string Key {get;}

        /// <summary>
        /// The option value
        /// </summary>
        public string Value {get;}

        [MethodImpl(Inline)]
        public ToolOption(string name, string value)
        {
            Key = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolOption((string name, string value) src)
            => new ToolOption(src.name, src.value);
    }
}