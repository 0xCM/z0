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
    public readonly struct WfConfigLoaded : IWfEvent<WfConfigLoaded>
    {
        public const string EventName = nameof(WfConfigLoaded);

        public WfEventId EventId {get;}

        public string ActorName {get;}

        public MessageFlair Flair {get;}

        public readonly FilePath SourcePath;

        public readonly WfSettings Settings;

        [MethodImpl(Inline)]
        public WfConfigLoaded(string actor, FilePath src, WfSettings data, CorrelationToken ct, MessageFlair flair = Finished)
        {
            EventId = z.evid(EventName, ct);
            ActorName = actor;
            Flair = flair;
            SourcePath = src;
            Settings = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx4, EventId, ActorName, SourcePath, Settings);
    }
}