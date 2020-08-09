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
    public readonly struct WfContextLoaded : IWfEvent<WfContextLoaded>
    {
        public const string EventName = nameof(WfContextLoaded);
        
        public WfEventId EventId {get;}

        public WfActor Actor {get;}
                        
        public AppMsgColor Flair {get;}
                                
        [MethodImpl(Inline)]
        public WfContextLoaded(WfActor actor, CorrelationToken ct, AppMsgColor flair = CreatedFlair)
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