//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RP;
    using static z;

    [Event]
    public readonly struct ExtractReportSaved : IWfEvent<ExtractReportSaved>
    {
        public const string EventName = nameof(ExtractReportSaved);

        public WfEventId EventId {get;}

        public Count Count {get;}

        public FS.FilePath Target {get;}
        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ExtractReportSaved(WfStepId step, Count count, FS.FilePath target, CorrelationToken ct, FlairKind flair = FlairKind.Ran)
        {
            EventId = (EventName, step, ct);
            Count = count;
            Target = target;
            Flair = flair;
        }

        public string Format()
            => Render.format(EventId, Count, Target);
    }
}