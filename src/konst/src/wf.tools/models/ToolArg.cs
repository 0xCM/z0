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
        public ushort Position {get;}

        /// <summary>
        /// The option protocol
        /// </summary>
        public CmdArgProtocol Protocol {get;}

        /// <summary>
        /// The option for which the argument is specified
        /// </summary>
        public ToolOption Option {get;}

        /// <summary>
        /// The argument value
        /// </summary>
        public string Value {get;}

        [MethodImpl(Inline)]
        public ToolArg(ushort position, CmdArgProtocol protocol, ToolOption option, string value)
        {
            Position = position;
            Protocol = protocol;
            Option = option;
            Value = value;
        }
    }
}