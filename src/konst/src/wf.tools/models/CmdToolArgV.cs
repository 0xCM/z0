//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CmdToolArg<V> : ICmdToolArg<V>
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
        public CmdToolArg(CmdOptionSpec option, ushort position,  V value)
        {
            Option = option;
            Position = position;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdToolArg(CmdToolArg<V> src)
            => new CmdToolArg(src.Option, src.Position, src.Value?.ToString() ?? EmptyString);
    }
}