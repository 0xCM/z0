//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RP;

    [Event]
    public readonly struct Unaddressed : IWfEvent<Unaddressed>
    {
        public WfEventId EventId {get;}

        public readonly OpUri Uri;

        public readonly BasedCodeBlock Code;

        [MethodImpl(Inline)]
        public Unaddressed(OpUri uri, BasedCodeBlock code, CorrelationToken ct)
        {
            EventId = WfEventId.define(nameof(Unaddressed), ct);
            Uri = uri;
            Code = code;
        }

        public FlairKind Flair
            => FlairKind.Error;

        public string Format()
            => text.format(PSx2, EventId, Uri);
    }
}