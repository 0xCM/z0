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

    public readonly struct CmdOption : ICmdOptionData<CmdOption>
    {
        public asci32 Id {get;}

        public string Value {get;}

        [MethodImpl(Inline)]
        public CmdOption(string name, string value)
        {
            Id = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public CmdOption(string name)
        {
            Id = name;
            Value = EmptyString;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}