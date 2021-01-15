//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct CmdArg<T> : ICmdArg<T>
    {
        /// <summary>
        /// The argument's relative position
        /// </summary>
        public ushort Position {get;}

        /// <summary>
        /// The (required) argument value
        /// </summary>
        public T Value {get;}

        public ArgPrefix Prefix {get;}

        public string Name {get;}

        public ArgQualifier Qualifier {get;}

        public ArgPartKind Classifier {get;}

        [MethodImpl(Inline)]
        public CmdArg(ushort pos, T value)
        {
            Position = pos;
            Name = EmptyString;
            Value = value;
            Prefix = EmptyString;
            Qualifier = ArgQualifier.Empty;
            Classifier = ArgPartKind.Position | ArgPartKind.Value;
        }

        [MethodImpl(Inline)]
        public CmdArg(string name, T value)
        {
            Position = 0;
            Name = name;
            Value = value;
            Prefix = EmptyString;
            Qualifier = ArgQualifier.Empty;
            Classifier = ArgPartKind.Name | ArgPartKind.Value;
        }

        [MethodImpl(Inline)]
        public CmdArg(ushort pos, ArgPrefix prefix, string name, ArgQualifier qualifier, T value)
        {
            Position = pos;
            Name = name;
            Value = value;
            Prefix = prefix;
            Qualifier = qualifier;
            Classifier = ArgPartKind.Position |  ArgPartKind.Prefix | ArgPartKind.Name | ArgPartKind.Qualifier | ArgPartKind.Value;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Cmd.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdArg<T>((string name, T value) src)
            => new CmdArg<T>(src.name, src.value);

        [MethodImpl(Inline)]
        public static implicit operator CmdArg(CmdArg<T> src)
            => new CmdArg(src.Name, src.Value?.ToString() ?? EmptyString);
    }
}