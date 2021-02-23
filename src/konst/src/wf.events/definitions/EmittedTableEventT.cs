//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System;

    using static Part;

    [Event(Kind)]
    public readonly struct EmittedTableEvent<T> : IWfEvent<EmittedTableEvent<T>>
    {
        public const string EventName = GlobalEvents.EmittedTable;

        public const EventKind Kind = EventKind.EmittedTable;

        public WfEventId EventId {get;}

        public TableId TableId => typeof(T);

        public Count RowCount {get;}

        public FS.FilePath Target {get;}

        public FlairKind Flair => FlairKind.Ran;

        [MethodImpl(Inline)]
        public EmittedTableEvent(WfStepId step, Count count, FS.FilePath target, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, step);
            RowCount = count;
            Target = target;
        }

        [MethodImpl(Inline)]
        public EmittedTableEvent(WfStepId step, FS.FilePath target, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, step);
            RowCount = 0;
            Target = target;
        }

        public string Format()
            => RowCount != 0
            ? TextFormatter.format(EventId, TableId, RowCount, Target.ToUri())
            : TextFormatter.format(EventId, TableId, Target.ToUri());

        public override string ToString()
            => Format();
    }
}