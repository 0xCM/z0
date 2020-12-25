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
        public ArgPrefix Prefix {get;}

        /// <summary>
        /// The argument name, if any
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The delimiter between an argument name/value pair, typically ' ' or ':'
        /// </summary>
        public ArgQualifier Qualifier {get;}

        /// <summary>
        /// The argument classifier
        /// </summary>
        public ArgPartKind Classifier {get;}

        [MethodImpl(Inline)]
        public CmdArg(ushort pos, ArgPrefix prefix, string name, string value)
        {
            Position = pos;
            Name = name;
            Value = value;
            Prefix = prefix;
            Qualifier = ArgQualifier.Empty;
            Classifier = ArgPartKind.Position | ArgPartKind.Prefix | ArgPartKind.Name | ArgPartKind.Value;
        }

        [MethodImpl(Inline)]
        public CmdArg(ushort pos, ArgPrefix prefix, string name, ArgQualifier qualifier, string value)
        {
            Position = pos;
            Name = name;
            Value = value;
            Prefix = prefix;
            Qualifier = qualifier;
            Classifier = ArgPartKind.Position | ArgPartKind.Prefix | ArgPartKind.Name | ArgPartKind.Qualifier | ArgPartKind.Value;
        }

        [MethodImpl(Inline)]
        public CmdArg(string name, string value)
        {
            Position = 0;
            Name = name;
            Value = value;
            Prefix = EmptyString;
            Qualifier = ArgQualifier.Empty;
            Classifier = ArgPartKind.Name | ArgPartKind.Value;
        }

        [MethodImpl(Inline)]
        public CmdArg(ushort pos, string name, string value)
        {
            Position = pos;
            Name = name;
            Value = value;
            Prefix = EmptyString;
            Qualifier = ArgQualifier.Empty;
            Classifier = ArgPartKind.Position | ArgPartKind.Name | ArgPartKind.Value;
        }


        [MethodImpl(Inline)]
        public CmdArg(ushort pos, string value)
        {
            Position = pos;
            Name = EmptyString;
            Value = value;
            Prefix = EmptyString;
            Qualifier = ArgQualifier.Empty;
            Classifier = ArgPartKind.Position | ArgPartKind.Value;
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