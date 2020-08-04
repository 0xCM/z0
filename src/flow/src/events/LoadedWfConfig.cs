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

        public const AppMsgColor DefaultFlair = AppMsgColor.Cyan;

        public WfEventId Id {get;}
        
        public string ActorName {get;}
        
        public AppMsgColor Flair {get;}
        
        public readonly FilePath ConfigPath;

        public readonly WfSettings ConfigData;

        public AppMsg Description {get;}

        [MethodImpl(Inline)]
        public LoadedWfConfig(string actor, FilePath src, WfSettings data, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            ActorName = actor;
            Flair = DefaultFlair;
            ConfigPath = src;
            ConfigData = data;
            Description = AppMsg.NoCaller(new {SourcePath = src}, AppMsgKind.Info);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, Id, ActorName, Description);        
    }
}