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

    using api = Cmd;

    public struct CmdArg<T> : ICmdArg<T>
    {
        public string Prefix {get;}

        public string Name {get;}

        public T Value {get;}

        public string Specifier {get;}

        [MethodImpl(Inline)]
        public CmdArg(string prefix, string name, T value)
        {
            Name = name;
            Value = value;
            Prefix = prefix;
            Specifier = EmptyString;
        }

        [MethodImpl(Inline)]
        public CmdArg(string key, T value)
        {
            Name = key;
            Value = value;
            Prefix = EmptyString;
            Specifier = EmptyString;
        }

        [MethodImpl(Inline)]
        public CmdArg(string prefix, string name, string specifier, T value)
        {
            Name = name;
            Value = value;
            Prefix = prefix;
            Specifier = specifier;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

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