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

    public readonly struct EventPayload : ITextual
    {
        public readonly BinaryCode Data;

        [MethodImpl(Inline)]
        public static implicit operator EventPayload(BinaryCode src)
            => new EventPayload(src);

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(EventPayload src)
            => src.Data;

        [MethodImpl(Inline)]
        public EventPayload(BinaryCode data)
            => Data = data;

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Data);

        public override string ToString()
            => Format();
    }
}