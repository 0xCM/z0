//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;

    [Event(EventName)]
    public readonly struct CmdCreatedEvent : IWfEvent<CmdCreatedEvent>
    {
        public const string EventName = nameof(GlobalEvents.CreatedToolCmd);

        public WfEventId EventId {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public CmdCreatedEvent(ToolId id, CorrelationToken ct, FlairKind flair = Created)
        {
            EventId = (EventName, id, ct);
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}