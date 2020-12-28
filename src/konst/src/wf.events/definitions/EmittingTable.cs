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
    public readonly struct EmittingTableEvent : IWfEvent<EmittingTableEvent>
    {
        public const string EventName = GlobalEvents.EmittingTable;

        public const EventKind Kind = EventKind.EmittingTable;

        public WfEventId EventId {get;}

        public TableId TableId {get;}

        public FS.FilePath Target {get;}

        public FlairKind Flair => FlairKind.Running;

        [MethodImpl(Inline)]
        public EmittingTableEvent(WfStepId step, Type type, FS.FilePath target, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            TableId = Records.tableid(type);
            Target = target;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId, TableId, Target.ToUri());

        public override string ToString()
            => Format();
    }
}