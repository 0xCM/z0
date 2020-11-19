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
        /// The option position
        /// </summary>
        public ushort Position {get;}

        /// <summary>
        /// The option protocol
        /// </summary>
        public CmdArgProtocol Protocol {get;}

        /// <summary>
        /// The option name
        /// </summary>
        public ToolOption Option {get;}

        /// <summary>
        /// The option value
        /// </summary>
        public V Value {get;}

        [MethodImpl(Inline)]
        public ToolArg(ushort position, CmdArgProtocol protocol, ToolOption option, V value)
        {
            Position = position;
            Protocol = protocol;
            Option = option;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolArg(ToolArg<V> src)
            => new ToolArg(src.Position, src.Protocol, src.Option, src.Value?.ToString() ?? EmptyString);
    }
}