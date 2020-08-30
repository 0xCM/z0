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
    public readonly struct WfEmitted : IWfEvent<WfEmitted>
    {
        public const string EventName = nameof(WfEmitted);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public TableId Dataset {get;}

        public readonly uint RowCount;

        public readonly FS.FilePath Target;

        [MethodImpl(Inline)]
        public WfEmitted(WfStepId step, TableId dataset, uint count, FilePath target, CorrelationToken ct)
        {
            EventId = z.evid(EventName, ct);
            StepId = step;
            Dataset = dataset;
            RowCount = count;
            Target = FS.path(target.Name);
        }

        [MethodImpl(Inline)]
        public WfEmitted(WfStepId step, TableId dataset, uint count, FS.FilePath target, CorrelationToken ct)
        {
            EventId = z.evid(EventName, ct);
            StepId = step;
            Dataset = dataset;
            RowCount = count;
            Target = target;
        }
        public string Format()
            => text.format(PSx5, EventId, StepId, Dataset, RowCount, Target);

        public override string ToString()
            => Format();
    }
}