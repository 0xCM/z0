//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents an argument, typically but not necessarily, on the command-line
    /// </summary>
    public struct CmdArg : ICmdArg
    {
        /// <summary>
        /// The argument's relative position
        /// </summary>
        public ushort Position {get;}

        /// <summary>
        /// The (required) argument value
        /// </summary>
        public string Value {get;}

        /// <summary>
        /// The argument prefix, if any; typically either '-', '--', or '/'
        /// </summary>
        public string Prefix {get;}

        /// <summary>
        /// The argument name, if any
        /// </summary>
        public CmdName Name {get;}

        /// <summary>
        /// The delimiter between an argument name/value pair, typically ' ' or ':'
        /// </summary>
        public string Qualifier {get;}

        [MethodImpl(Inline)]
        public CmdArg(ushort pos, string prefix, string name, string value)
        {
            Position = pos;
            Name = name;
            Value = value;
            Prefix = prefix;
            Qualifier = EmptyString;
        }

        [MethodImpl(Inline)]
        public CmdArg(ushort pos, string prefix, string name, string qualifier, string value)
        {
            Position = pos;
            Name = name;
            Value = value;
            Prefix = prefix;
            Qualifier = qualifier;
        }

        [MethodImpl(Inline)]
        public CmdArg(string name, string value)
        {
            Position = 0;
            Name = name;
            Value = value;
            Prefix = EmptyString;
            Qualifier = EmptyString;
        }

        [MethodImpl(Inline)]
        public CmdArg(ushort pos, string name, string value)
        {
            Position = pos;
            Name = name;
            Value = value;
            Prefix = EmptyString;
            Qualifier = EmptyString;
        }


        [MethodImpl(Inline)]
        public CmdArg(ushort pos, string value)
        {
            Position = pos;
            Name = EmptyString;
            Value = value;
            Prefix = EmptyString;
            Qualifier = EmptyString;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Value);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !text.empty(Value);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Cmd.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdArg(Pair<string> src)
            => new CmdArg(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator CmdArg((string name, string value) src)
            => new CmdArg(src.name, src.value);

        public static CmdArg Empty
        {
            [MethodImpl(Inline)]
            get => new CmdArg(EmptyString, EmptyString);
        }
    }
}