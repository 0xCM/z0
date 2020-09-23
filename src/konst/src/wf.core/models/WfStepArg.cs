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

    public readonly struct WfStepArg : IWfStepArg, ITextual
    {
        public byte Index {get;}

        public object Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator WfStepArg((byte index, string value) src)
            => new WfStepArg(src.index, src.value);

        [MethodImpl(Inline)]
        public WfStepArg(byte index, object value)
        {
            Index = index;
            Value = value;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(RP.Slot0, Value);
    }
}