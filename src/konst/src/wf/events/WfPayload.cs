//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfPayload<T> : ITextual
    {
        public readonly T Data;

        [MethodImpl(Inline)]
        public static implicit operator WfPayload<T>(T src)
            => new WfPayload<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(WfPayload<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public WfPayload(T data)
            => Data = data;

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Data);

        public override string ToString()
            => Format();
    }
}