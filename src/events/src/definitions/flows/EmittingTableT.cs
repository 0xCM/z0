//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System;

    using static Root;

    [Event(Kind)]
    public readonly struct EmittingTableEvent<T> : IInitialEvent<EmittingTableEvent<T>>
    {
        public const string EventName = GlobalEvents.EmittingTable;

        public const EventKind Kind = EventKind.EmittingTable;

        public EventId EventId {get;}

        public TableId TableId => TableId.identify(typeof(T));

        public FS.FilePath Target {get;}

        public FlairKind Flair => FlairKind.Running;

        [MethodImpl(Inline)]
        public EmittingTableEvent(WfStepId step, FS.FilePath target, CorrelationToken ct)
        {
            EventId = EventId.define(EventName, step);
            Target = target;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(EventId, Msg.EmittingTable.Capture(TableId, Target));

        public override string ToString()
            => Format();
    }
}