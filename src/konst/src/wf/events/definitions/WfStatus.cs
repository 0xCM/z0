//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static RenderPatterns;
    using static z;

    [Event]
    public readonly struct WfStatus : IWfEvent<WfStatus, string>
    {
        public const string EventName = nameof(WfStatus);

        public WfEventId EventId {get;}

        public string ActorName {get;}

        public string Content {get;}

        public MessageFlair Flair {get;}

        public AppMsg Description {get;}

        [MethodImpl(Inline)]
        public WfStatus(string actor, string body, CorrelationToken ct, MessageFlair flair = Status)
        {
            EventId = evid(EventName, ct);
            ActorName = actor;
            Content = body;
            Flair =  flair;
            Description = AppMsg.colorize(Content, Flair);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, ActorName, Description);
    }
}