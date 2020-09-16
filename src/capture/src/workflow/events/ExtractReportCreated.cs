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

    public readonly struct ExtractReportCreated : IWfEvent<ExtractReportCreated>
    {
        public const string EventName = nameof(ExtractReportCreated);

        public WfEventId EventId {get;}

        public ApiHostUri Host {get;}

        public Count Count {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ExtractReportCreated(WfStepId step, ApiHostUri host, Count count, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            Host = host;
            Count = count;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Host, Count);
    }
}