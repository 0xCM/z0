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

    public struct CmdOption<T> : ICmdOption<T>
    {
        public string Name;

        public T Value;

        [MethodImpl(Inline)]
        public CmdOption(string id, T value)
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
        public static implicit operator CmdOption<T>((string name, T value) src)
            => new CmdOption<T>(src.name, src.value);

        [MethodImpl(Inline)]
        public static implicit operator CmdOption(CmdOption<T> src)
            => new CmdOption(src.Name, src.Value?.ToString() ?? EmptyString);

        string ICmdOption.Name
            => Name;

        T ICmdOption<T>.Value
            => Value;
    }
}