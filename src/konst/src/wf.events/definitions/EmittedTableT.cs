//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System;

    using static Part;

    [Event(EventName)]
    public readonly struct EmittedTableEvent<T> : IWfEvent<EmittedTableEvent<T>>
    {
        public const string EventName = GlobalEvents.EmittedTable;

        public WfEventId EventId {get;}

        public TableId TableId => typeof(T);

        public Count RowCount {get;}

        public FS.FilePath Target {get;}

        public FlairKind Flair => FlairKind.Ran;

        [MethodImpl(Inline)]
        public EmittedTableEvent(WfStepId step, Count count, FS.FilePath target, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            RowCount = count;
            Target = target;
        }

        public string Format()
            => TextFormatter.format(EventId, TableId, RowCount, Target.ToUri());

        public override string ToString()
            => Format();
    }
}