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

    partial struct WfEvents
    {
        public readonly struct ToolRunning : IWfEvent<ToolRunning>
        {
            public WfEventId EventId {get;}

            public ToolId ToolId {get;}

            public FlairKind Flair {get;}

            [MethodImpl(Inline)]
            public ToolRunning(ToolId tool, CorrelationToken ct, FlairKind flair = Running)
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
}