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
    using static z;
    
    [Event]
    public readonly struct WfContextUnloaded : IWfEvent<WfContextUnloaded>
    {
        public const string EventName = nameof(WfContextUnloaded);
                
        public WfEventId EventId {get;}

        public WfActor Actor {get;}
                
        public AppMsgColor Flair {get;}
        
        [MethodImpl(Inline)]
        public WfContextUnloaded(WfActor actor, CorrelationToken ct, AppMsgColor flair = FinishedFlair)
        {
            EventId = z.evid(EventName, ct);
            Actor = actor;
            Flair = flair;
        }
        
        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Actor);        
    }
}