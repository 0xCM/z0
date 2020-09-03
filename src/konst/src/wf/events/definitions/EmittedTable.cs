//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System;

    using static Konst;
    using static RenderPatterns;

    partial struct WfEvents
    {
        public readonly struct EmittedTable : IWfEvent<EmittedTable>
        {
            public const string EventName = nameof(EmittedTable);

            public WfEventId EventId {get;}

            public WfStepId StepId {get;}

            public TableId Dataset {get;}

            public readonly uint RowCount;

            public readonly FS.FilePath Target;

            [MethodImpl (Inline)]
            public EmittedTable (WfStepId step, TableId dataset, uint count, FilePath target, CorrelationToken ct)
            {
                EventId = z.evid (EventName, ct);
                StepId = step;
                Dataset = dataset;
                RowCount = count;
                Target = FS.path (target.Name);
            }

            [MethodImpl (Inline)]
            public EmittedTable (WfStepId step, TableId dataset, uint count, FS.FilePath target, CorrelationToken ct)
            {
                EventId = z.evid (EventName, ct);
                StepId = step;
                Dataset = dataset;
                RowCount = count;
                Target = target;
            }
            public string Format ()
                => text.format(PSx5, EventId, StepId, Dataset, RowCount, Target);

            public override string ToString()
                => Format();
        }
    }
}