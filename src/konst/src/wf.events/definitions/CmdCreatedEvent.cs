//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(EventName)]
    public readonly struct CmdCreatedEvent : IWfEvent<CmdCreatedEvent>
    {
        public const string EventName = GlobalEvents.CreatedToolCmd;

        public WfEventId EventId {get;}

        public FlairKind Flair => FlairKind.Created;

        [MethodImpl(Inline)]
        public CmdCreatedEvent(ToolId id, CorrelationToken ct)
        {
            EventId = (EventName, id, ct);
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}