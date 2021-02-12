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
        /// The argument name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The (required) argument value
        /// </summary>
        public T Value {get;}

        public ArgProtocol Protocol {get;}

        public ArgPartKind Classifier {get;}

        public bool IsFlag {get;}

        [MethodImpl(Inline)]
        public CmdArg(ushort pos, T value, bool flag = false)
        {
            Position = pos;
            Name = EmptyString;
            Value = value;
            Protocol = (ArgPrefix.Space, ArgQualifier.Space);
            Classifier = ArgPartKind.Position | ArgPartKind.Value;
            IsFlag = flag;
        }

        [MethodImpl(Inline)]
        public CmdArg(string name, T value, bool flag = false)
        {
            Position = 0;
            Name = name;
            Value = value;
            Protocol = (ArgPrefix.Space, ArgQualifier.Space);
            Classifier = ArgPartKind.Name | ArgPartKind.Value;
            IsFlag = flag;
        }


        [MethodImpl(Inline)]
        public CmdArg(ushort pos, string name,  T value, ArgProtocol protocol, bool flag = false)
        {
            Position = pos;
            Name = name;
            Value = value;
            Protocol = protocol;
            Classifier = ArgPartKind.Position |  ArgPartKind.Prefix | ArgPartKind.Name | ArgPartKind.Qualifier | ArgPartKind.Value;
            IsFlag = flag;
        }

        public ArgPrefix Prefix => Protocol.Prefix;

        public ArgQualifier Qualifier => Protocol.Qualifier;


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
            => new CmdArg(src.Name, src.Value);
    }
}