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
    public readonly struct LoadingWfConfig : IWfEvent<LoadingWfConfig, FilePath>
    {
        public const string EventName = nameof(LoadingWfConfig);        
                
        public WfEventId EventId {get;}

        public string ActorName {get;}
        
        public FilePath Body {get;}        
        
        public AppMsgColor Flair {get;}        

        [MethodImpl(Inline)]
        public LoadingWfConfig(string worker, FilePath body, CorrelationToken ct, AppMsgColor flair = RunningFlair)
        {
            EventId = wfid(EventName, ct);
            ActorName = worker ?? "anonymous";
            Body = body;
            Flair = flair;            
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, ActorName, Body);            
    }
}