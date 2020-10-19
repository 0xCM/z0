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

    public readonly struct CmdOption<T> : ICmdOptionData<CmdOption<T>,T>, IIdentified<asci32>
    {
        public asci32 Id {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public CmdOption(string id, T value)
        {
            Id = id;
            Value = value;
        }

        [MethodImpl(Inline)]
        internal CmdOption(in asci32 id, T value)
        {
            Id = id;
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
            => new CmdOption(src.Id, src.Value?.ToString() ?? EmptyString);
    }
}