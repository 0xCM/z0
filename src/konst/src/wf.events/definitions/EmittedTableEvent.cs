//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(Kind)]
    public readonly struct EmittedTableEvent : IWfEvent<EmittedTableEvent>
    {
        public const string EventName = GlobalEvents.EmittedTable;

        public const EventKind Kind = EventKind.EmittedTable;

        public WfEventId EventId {get;}

        public TableId TableId {get;}

        public Count RowCount {get;}

        public FS.FilePath Target {get;}

        public FlairKind Flair => FlairKind.Ran;

        [MethodImpl(Inline)]
        public EmittedTableEvent(WfStepId step, TableId dataset, uint count, FS.FilePath target, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            TableId = dataset;
            RowCount = count;
            Target = target;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId, TableId, RowCount, Target.ToUri());

        public override string ToString()
            => Format();
    }
}