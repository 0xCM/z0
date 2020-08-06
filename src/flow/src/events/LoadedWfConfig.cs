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
    public readonly struct LoadedWfConfig : IWfEvent<LoadedWfConfig>
    {        
        public const string EventName = nameof(LoadedWfConfig);

        public WfEventId Id {get;}
        
        public string ActorName {get;}        
        
        public AppMsgColor Flair {get;}
        
        public readonly FilePath ConfigPath;

        public readonly WfSettings ConfigData;

        [MethodImpl(Inline)]
        public LoadedWfConfig(string actor, FilePath src, WfSettings data, CorrelationToken ct, AppMsgColor flair = FinishedFlair)
        {
            Id = wfid(EventName, ct);
            ActorName = actor;
            Flair = flair;
            ConfigPath = src;
            ConfigData = data;            
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx4, Id, ActorName, ConfigPath, ConfigData);
    }
}