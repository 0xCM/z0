//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolOption<F> : IToolOption<F>
        where F : unmanaged, Enum
    {
        public F Flag {get;}

        public string Value {get;}

        [MethodImpl(Inline)]
        public ToolOption(F flag, string value)
        {
            Flag = flag;
            Value = value;
        }
    }
}