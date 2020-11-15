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

    public readonly struct ToolArg<V> : IToolArg<V>
    {
        /// <summary>
        /// The option name
        /// </summary>
        public ToolOption Option {get;}

        /// <summary>
        /// The option value
        /// </summary>
        public V Value {get;}

        [MethodImpl(Inline)]
        public ToolArg(ToolOption option, V value)
        {
            Option = option;
            Value = value;
        }

        [MethodImpl(Inline)]
        public ToolArg(string option, V value)
        {
            Option = option;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolArg<V>((string option, V value) src)
            => new ToolArg<V>(src.option, src.value);

        [MethodImpl(Inline)]
        public static implicit operator ToolArg<V>((ToolOption option, V value) src)
            => new ToolArg<V>(src.option, src.value);

        [MethodImpl(Inline)]
        public static implicit operator ToolArg(ToolArg<V> src)
            => new ToolArg(src.Option, src.Value?.ToString() ?? EmptyString);
    }
}