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
    public readonly struct ToolArg : IToolArg
    {
        /// <summary>
        /// The option for which the argument is specified
        /// </summary>
        public CmdOptionSpec Option {get;}

        /// <summary>
        /// The 0-based argument position
        /// </summary>
        public ushort Position {get;}

        /// <summary>
        /// The argument value
        /// </summary>
        public string Value {get;}

        [MethodImpl(Inline)]
        public ToolArg(CmdOptionSpec option, ushort position, string value)
        {
            Position = position;
            Option = option;
            Value = value;
        }
    }
}