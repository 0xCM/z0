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
    public readonly struct WfActorFinished : IWfEvent<WfActorFinished>
    {
        public const string EventName = nameof(WfActorFinished);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public MessageFlair Flair {get;}


        [MethodImpl(Inline)]
        public WfActorFinished(WfActor actor, CorrelationToken ct, MessageFlair flair = Finished)
        {
            EventId = evid(EventName, ct);
            Actor = actor;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx2, EventId, Actor);
    }
}