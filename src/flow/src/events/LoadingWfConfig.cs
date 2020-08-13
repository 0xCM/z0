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
    using static z;

    [Event]
    public readonly struct LoadingWfConfig : IWfEvent<LoadingWfConfig>
    {
        public const string EventName = nameof(LoadingWfConfig);        
                
        public WfEventId EventId {get;}

        public string ActorName {get;}
        
        public FilePath SourcePath {get;}        
        
        public AppMsgColor Flair {get;}        

        [MethodImpl(Inline)]
        public LoadingWfConfig(string actor, FilePath body, CorrelationToken ct, AppMsgColor flair = Running)
        {
            EventId = z.evid(EventName, ct);
            ActorName = actor;
            SourcePath = body;
            Flair = flair;            
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, ActorName, SourcePath);            
    }
}