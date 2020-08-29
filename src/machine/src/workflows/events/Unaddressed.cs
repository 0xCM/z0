//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RenderPatterns;

    [Event]
    public readonly struct Unaddressed : IWfEvent<Unaddressed>
    {
        public WfEventId EventId {get;}

        public readonly OpUri Uri;

        public readonly X86Code Code;

        [MethodImpl(Inline)]
        public Unaddressed(OpUri uri, X86Code code)
        {
            EventId = WfEventId.define(nameof(Unaddressed));
            Uri = uri;
            Code = code;
        }

        public MessageFlair Flair
            => MessageFlair.Red;

        public string Format()
            => text.format(PSx2, EventId, Uri);
    }
}