//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a tool flag argument
    /// </summary>
    public readonly struct CmdFlag : IToolCmdArg
    {
        /// <summary>
        /// The argument's relative position
        /// </summary>
        public ushort Position {get;}

        /// <summary>
        /// The flag name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The argument value
        /// </summary>
        public dynamic Value {get;}

        public ArgProtocol Protocol {get;}

        public ArgPartKind Classifier {get;}

        [MethodImpl(Inline)]
        public CmdFlag(ushort pos, string name, ArgPrefix? prefix = null)
        {
            Position = pos;
            Name = name;
            Value = EmptyString;
            Protocol = prefix ?? ArgPrefix.DoubleDash;
            Classifier = ArgPartKind.Name | ArgPartKind.Position;
        }

        [MethodImpl(Inline)]
        public CmdFlag(string name, ArgPrefix? prefix = null)
        {
            Position = 0;
            Name = name;
            Value = EmptyString;
            Protocol = prefix ?? ArgPrefix.DoubleDash;
            Classifier = ArgPartKind.Name;
        }

        public bool IsFlag
            => true;

        public ArgPrefix Prefix
            => Protocol.Prefix;

        public ArgQualifier Qualifier
            => Protocol.Qualifier;

        [MethodImpl(Inline)]
        public static implicit operator ToolCmdArg(CmdFlag src)
            => new ToolCmdArg(src.Position, src.Name, src.Value, src.Prefix, true);
    }
}