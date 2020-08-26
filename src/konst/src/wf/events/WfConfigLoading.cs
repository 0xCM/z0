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
    using static RenderPatterns;
    using static z;

    [Event]
    public readonly struct WfConfigLoading : IWfEvent<WfConfigLoading>
    {
        public const string EventName = nameof(WfConfigLoading);

        public WfEventId EventId {get;}

        public string ActorName {get;}

        public FilePath SourcePath {get;}

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WfConfigLoading(string actor, FilePath body, CorrelationToken ct, MessageFlair flair = Running)
        {
            EventId = z.evid(EventName, ct);
            ActorName = actor;
            SourcePath = body;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, ActorName, SourcePath);
    }
}