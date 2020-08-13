//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static Flow;
    using static FormatPatterns;

    [Event]
    public readonly struct ActorFinished : IWfEvent<ActorFinished>
    {        
        public const string EventName = nameof(ActorFinished);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public AppMsgColor Flair {get;}

        
        [MethodImpl(Inline)]
        public ActorFinished(WfActor actor, CorrelationToken ct, AppMsgColor flair = Finished)
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