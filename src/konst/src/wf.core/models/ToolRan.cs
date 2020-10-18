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
    public readonly struct ToolRanEvent : IWfEvent<ToolRanEvent>
    {
        public const string EventName = "ToolRan";

        public WfEventId EventId {get;}

        public ToolId ToolId {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ToolRanEvent(ToolId tool, CorrelationToken ct, FlairKind flair = Ran)
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