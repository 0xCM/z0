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

    public readonly struct WfStepArg<T>: IWfStepArg<T>, ITextual
    {
        public byte Index {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator WfStepArg<T>((byte index, T value) src)
            => new WfStepArg<T>(src.index, src.value);

        [MethodImpl(Inline)]
        public WfStepArg(byte index, T value)
        {
            Index = index;
            Value = value;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(RP.Slot0, Value);
    }
}