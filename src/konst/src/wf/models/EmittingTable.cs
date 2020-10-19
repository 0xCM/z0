//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System;

    using static Konst;

    [Event(EventName)]
    public readonly struct EmittingTableEvent : IWfEvent<EmittingTableEvent>
    {
        public const string EventName = nameof(GlobalEvents.EmittingTable);

        public WfEventId EventId {get;}

        public TableId TableId {get;}

        public FS.FilePath Target {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public EmittingTableEvent(WfStepId step, Type tt,  FS.FilePath target, CorrelationToken ct, FlairKind flair = FlairKind.Running)
        {
            EventId = (EventName, step, ct);
            Flair = flair;
            TableId = Table.id(tt);
            Target = target;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, TableId, Target.ToUri());

        public override string ToString()
            => Format();
    }
}