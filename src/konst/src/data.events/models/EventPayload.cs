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

    public readonly struct EventPayload<T> : ITextual
    {
        public readonly T Data;

        [MethodImpl(Inline)]
        public static implicit operator EventPayload<T>(T src)
            => new EventPayload<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(EventPayload<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public EventPayload(T data)
            => Data = data;

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Data);

        public override string ToString()
            => Format();
    }
}