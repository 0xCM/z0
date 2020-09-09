//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;

    using E = ExtractsParsed;

    public readonly struct ExtractsParsed : IWfEvent<E>
    {
        public const string EventName = nameof(ExtractsParsed);

        public WfEventId EventId {get;}

        public ApiHostUri Host {get;}

        public Count32 MemberCount {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ExtractsParsed(WfStepId step, ApiHostUri host, Count32 count, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            Host = host;
            MemberCount = count;
            Flair = flair;
        }

        public string Format()
            => format(EventId, Host, MemberCount);
    }
}