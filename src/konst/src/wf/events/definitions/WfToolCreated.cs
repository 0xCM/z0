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

    public readonly struct WfToolCreated : IWfEvent<WfToolCreated>
    {
        public WfEventId EventId {get;}

        public WfToolId ToolId {get;}

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WfToolCreated(WfToolId tool, CorrelationToken ct, MessageFlair flair = Created)
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