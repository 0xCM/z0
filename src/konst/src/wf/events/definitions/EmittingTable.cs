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

    partial struct WfEvents
    {
        [Event]
        public readonly struct EmittingTable : IWfEvent<EmittingTable>
        {
            public const string EventName = nameof(EmittingTable);

            public WfEventId EventId {get;}

            public WfStepId StepId {get;}

            public TableId Dataset {get;}

            public FS.FilePath Target {get;}

            [MethodImpl(Inline)]
            public EmittingTable(WfStepId step, TableId dataset, FilePath target, CorrelationToken ct)
            {
                EventId = (EventName,step,ct);
                StepId = step;
                Dataset = dataset;
                Target = FS.path(target.Name);
            }

            [MethodImpl(Inline)]
            public EmittingTable(WfStepId step, TableId dataset, FS.FilePath target, CorrelationToken ct)
            {
                EventId = (EventName,step,ct);
                StepId = step;
                Dataset = dataset;
                Target = target;
            }

            [MethodImpl(Inline)]
            public string Format()
                => Render.format(EventId, StepId, Dataset, Target);
        }
    }
}