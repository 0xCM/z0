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
        public string Key {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public CmdArg(string key, T value)
        {
            Key = key;
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
            => new CmdArg(src.Key, src.Value?.ToString() ?? EmptyString);
    }
}