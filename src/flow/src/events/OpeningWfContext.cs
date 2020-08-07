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

    [Event]
    public readonly struct OpeningWfContext : IWfEvent<OpeningWfContext>
    {
        public const string EventName = nameof(OpeningWfContext);
        
        public WfEventId EventId {get;}

        public string ActorName {get;}
        
        public Type ContextType {get;}
                
        public AppMsgColor Flair {get;}
                
        [MethodImpl(Inline)]
        public OpeningWfContext(string worker, Type type, CorrelationToken ct, AppMsgColor flair = CreatedFlair)
        {
            EventId = wfid(EventName, ct);
            ActorName = worker;
            ContextType = type;
            Flair = flair;            
        }
        
        public string Description 
            => text.format("Opening {0}", ContextType.DisplayName());

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, ActorName, Description);        
    }
}