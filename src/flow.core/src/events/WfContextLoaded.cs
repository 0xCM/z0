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
    public readonly struct WfContextLoaded : IWfEvent<WfContextLoaded>
    {
        public const string EventName = nameof(WfContextLoaded);
        
        public WfEventId EventId {get;}

        public WfActor Actor {get;}
                        
        public MessageFlair Flair {get;}
                                
        [MethodImpl(Inline)]
        public WfContextLoaded(WfActor actor, CorrelationToken ct, MessageFlair flair = Created)
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