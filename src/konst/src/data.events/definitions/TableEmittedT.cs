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

    public readonly struct TableEmittedEvent<T> : IWfEvent<TableEmittedEvent<T>>
    {
        public const string EventName = nameof(GlobalEvents.TableEmitted);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public ClrType<T> RowType => default;

        public Count RowCount {get;}

        public FS.FilePath Target {get;}

        [MethodImpl(Inline)]
        public TableEmittedEvent(WfStepId step, T[] rows, FS.FilePath target, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            RowCount = rows.Length;
            Target = target;
        }

        [MethodImpl(Inline)]
        public TableEmittedEvent(WfStepId step, ReadOnlySpan<T> rows, FS.FilePath target, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            RowCount = rows.Length;
            Target = target;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx4, EventId, RowType, RowCount, Target.ToUri());

        public override string ToString()
            => Format();
    }
}