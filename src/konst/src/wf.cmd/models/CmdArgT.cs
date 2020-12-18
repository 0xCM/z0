//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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

        public string Prefix {get;}

        public CmdName Name {get;}

        public string Qualifier {get;}

        [MethodImpl(Inline)]
        public CmdArg(ushort index, string prefix, string name, T value)
        {
            Position = index;
            Name = name;
            Value = value;
            Prefix = prefix;
            Qualifier = EmptyString;
        }

        [MethodImpl(Inline)]
        public CmdArg(string key, T value)
        {
            Position = 0;
            Name = key;
            Value = value;
            Prefix = EmptyString;
            Qualifier = EmptyString;
        }

        [MethodImpl(Inline)]
        public CmdArg(ushort index, string prefix, string name, string specifier, T value)
        {
            Position = index;
            Name = name;
            Value = value;
            Prefix = prefix;
            Qualifier = specifier;
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