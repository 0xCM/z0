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

        public TableId TableId => Tables.tableid(typeof(T));

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
            => text.format(EventId, Msg.EmittedTable.Capture(TableId, RowCount, Target));


        public override string ToString()
            => Format();
    }
}