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
        public string Name;

        public T Value;

        [MethodImpl(Inline)]
        public CmdArg(string id, T value)
        {
            Name = id;
            Value = value;
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

        string ICmdArg.Key
            => Name;

        T ICmdArg<T>.Value
            => Value;
    }
}