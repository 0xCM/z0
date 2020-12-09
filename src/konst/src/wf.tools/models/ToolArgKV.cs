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
    /// Defines a tool option argument
    /// </summary>
    public readonly struct ToolArg<K,V> : IToolArg<K,V>
        where K : unmanaged
    {
        /// <summary>
        /// The specified option
        /// </summary>
        public CmdOptionSpec<K> Option {get;}

        /// <summary>
        /// The 0-based argument position
        /// </summary>
        public ushort Position {get;}

        /// <summary>
        /// The option value
        /// </summary>
        public V Value {get;}

        [MethodImpl(Inline)]
        public ToolArg(CmdOptionSpec<K> option, ushort position, V value)
        {
            Position = position;
            Option = option;
            Value = value;
        }
    }
}