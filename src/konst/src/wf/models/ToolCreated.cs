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
    public readonly struct ToolCreatedEvent : IWfEvent<ToolCreatedEvent>
    {
        public const string EventName = GlobalEvents.ToolCreated;

        public WfEventId EventId {get;}

        public ToolId ToolId {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ToolCreatedEvent(ToolId tool, CorrelationToken ct, FlairKind flair = Created)
        {
            EventId = (tool, ct);
            ToolId = tool;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}