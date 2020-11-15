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

    /// <summary>
    /// Defines a tool option argument
    /// </summary>
    public readonly struct ToolArg : IToolArg
    {
        /// <summary>
        /// The option for which the argument is specified
        /// </summary>
        public ToolOption Option {get;}

        /// <summary>
        /// The argument value
        /// </summary>
        public string Value {get;}

        [MethodImpl(Inline)]
        public ToolArg(string option, string value)
        {
            Option = option;
            Value = value;
        }

        [MethodImpl(Inline)]
        public ToolArg(ToolOption option, string value)
        {
            Option = option;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolArg((string name, string value) src)
            => new ToolArg(src.name, src.value);

        [MethodImpl(Inline)]
        public static implicit operator ToolArg((ToolOption option, string value) src)
            => new ToolArg(src.option, src.value);
    }
}