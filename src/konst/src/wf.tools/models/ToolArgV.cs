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
        /// The option name
        /// </summary>
        public CmdOptionSpec Option {get;}

        /// <summary>
        /// The option value
        /// </summary>
        public V Value {get;}

        [MethodImpl(Inline)]
        public ToolArg(CmdOptionSpec option, ushort position,  V value)
        {
            Option = option;
            Position = position;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator ToolArg(ToolArg<V> src)
            => new ToolArg(src.Option, src.Position, src.Value?.ToString() ?? EmptyString);
    }
}