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
    using static RenderPatterns;
    using static Render;

    [Event]
    public readonly struct ActorCreated : IWfEvent<ActorCreated>
    {        
        public const string EventName = nameof(ActorCreated);        

        public WfEventId EventId {get;}

        public WfActor Actor {get;}        
        
        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public ActorCreated(in WfActor actor, CorrelationToken ct, MessageFlair flair = Created)
        {
            EventId = z.evid(EventName, ct);
            Actor = actor;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx2, EventId, Actor);
    }
}