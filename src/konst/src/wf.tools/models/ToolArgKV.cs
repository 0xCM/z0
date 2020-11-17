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
    public readonly struct ToolArg<K,V> : IToolArg<K,V>
        where K : unmanaged
    {
        /// <summary>
        /// The 0-based argument position
        /// </summary>
        public ushort Position {get;}

        /// <summary>
        /// The option protocol
        /// </summary>
        public OptionProtocol Protocol {get;}

        /// <summary>
        /// The specified option
        /// </summary>
        public ToolOption<K> Option {get;}

        /// <summary>
        /// The option value
        /// </summary>
        public V Value {get;}

        [MethodImpl(Inline)]
        public ToolArg(ushort position, OptionProtocol protocol, K kind, V value)
        {
            Position = position;
            Protocol = protocol;
            Option = kind;
            Value = value;
        }
    }
}