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
        public readonly struct ToolRan : IWfEvent<ToolRan>
        {
            public WfEventId EventId {get;}

            public WfToolId ToolId {get;}

            public FlairKind Flair {get;}

            [MethodImpl(Inline)]
            public ToolRan(WfToolId tool, CorrelationToken ct, FlairKind flair = Ran)
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