//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct WfFuncArg : IWfFuncArg, ITextual
    {
        public byte Index {get;}

        public ulong Value {get;}

        [MethodImpl(Inline)]
        public WfFuncArg(byte index, ulong value)
        {
            Index = index;
            Value = value;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(RP.PSx2, Index, Value);

        [MethodImpl(Inline)]
        public static implicit operator WfFuncArg((byte index, ulong value) src)
            => new WfFuncArg(src.index, src.value);
    }
}