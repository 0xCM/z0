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

    [Event(EventName)]
    public readonly struct EmittedTableEvent<T> : IWfEvent<EmittedTableEvent<T>>
    {
        public const string EventName = nameof(GlobalEvents.EmittedTable);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public Type RowType => typeof(T);

        public Count RowCount {get;}

        public FS.FilePath Target {get;}

        [MethodImpl(Inline)]
        public EmittedTableEvent(WfStepId step, Count count, FS.FilePath target, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            RowCount = count;
            Target = target;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx4, EventId, RowType.Name, RowCount, Target.ToUri());

        public override string ToString()
            => Format();
    }
}