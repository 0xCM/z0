//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(Kind)]
    public class EmittedTableEvent<T> : IWfEvent<EmittedTableEvent<T>>
    {
        public const string EventName = GlobalEvents.EmittedTable;

        public const EventKind Kind = EventKind.EmittedTable;

        public WfEventId EventId {get;}

        public Count RowCount {get;}

        public FS.FilePath Target {get;}

        public EmittedTableEvent()
        {
            EventId = WfEventId.Empty;
            RowCount = 0;
            Target = FS.FilePath.Empty;
        }

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

        public TableId TableId => Tables.tableid(typeof(T));

        public FlairKind Flair => FlairKind.Ran;

        public string Format()
            => text.format(EventId, Msg.EmittedTable.Capture(TableId, RowCount, Target));


        public override string ToString()
            => Format();
    }
}