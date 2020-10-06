//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System;

    using static Konst;
    using static RP;

    public readonly struct TableEmitted : IWfEvent<TableEmitted>
    {
        public const string EventName = nameof(TableEmitted);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public TableId Dataset {get;}

        public Count RowCount {get;}

        public FS.FilePath Target {get;}

        [MethodImpl(Inline)]
        public TableEmitted(WfStepId step, TableId dataset, uint count, FS.FilePath target, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            Dataset = dataset;
            RowCount = count;
            Target = target;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx5, EventId, StepId, Dataset, RowCount, Target.ToUri());

        public override string ToString()
            => Format();
    }
}