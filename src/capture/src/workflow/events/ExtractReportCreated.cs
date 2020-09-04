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

        public WfActor Actor {get;}

        public CorrelationToken Ct {get;}

        public FlairKind Flair {get;}

        public readonly Count32 RecordCount;

        [MethodImpl(Inline)]
        public ExtractReportCreated(string actor, Count32 count, CorrelationToken ct, FlairKind flair = Ran)
        {
            Actor = actor;
            EventId = evid(EventName, ct);
            Ct = ct;
            RecordCount = count;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Actor, RecordCount);
    }
}