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

    public readonly struct WfFuncArg<T>: IWfFuncArg<T>, ITextual
    {
        public byte Index {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public WfFuncArg(byte index, T value)
        {
            Index = index;
            Value = value;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(RP.Slot0, Value);

        [MethodImpl(Inline)]
        public static implicit operator WfFuncArg<T>((byte index, T value) src)
            => new WfFuncArg<T>(src.index, src.value);
    }
}