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
    using static z;

    [Event]
    public readonly struct WfEmitting : IWfEvent<WfEmitting>
    {
        public const string EventName = nameof(WfEmitting);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public TableId Dataset {get;}

        public FS.FilePath Target {get;}

        [MethodImpl(Inline)]
        public WfEmitting(WfStepId step, TableId dataset, FilePath target, CorrelationToken ct)
        {
            StepId = step;
            EventId = z.evid(EventName, ct);
            Dataset = dataset;
            Target = FS.path(target.Name);
        }

        [MethodImpl(Inline)]
        public WfEmitting(WfStepId step, TableId dataset, FS.FilePath target, CorrelationToken ct)
        {
            StepId = step;
            EventId = z.evid(EventName, ct);
            Dataset = dataset;
            Target = target;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx4, EventId, StepId, Dataset, Target);
    }
}