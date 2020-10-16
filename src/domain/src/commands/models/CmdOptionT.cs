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

    public struct CmdOptionData<T>
    {
        public asci32 OptionName;

        public T OptionValue;
    }

    public readonly struct CmdOption<T> : ICmdOptionData<CmdOption<T>,T>
    {
        public asci32 Name {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public CmdOption(string name, T value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        internal CmdOption(asci32 name, T value)
        {
            Name = name;
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
    }
}