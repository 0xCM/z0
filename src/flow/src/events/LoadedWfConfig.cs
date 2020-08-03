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
    using static LoadedWfConfigEvent;

    [Event(true)]
    public readonly struct LoadedWfConfigEvent
    {   
        public const string EventName = nameof(LoadedWfConfig);

        public const string Pattern = IdMarker + "Comleted workflow load from {1}";

        public const AppMsgColor DefaultFlair = AppMsgColor.Cyan;
    }
    
    [Event]
    public readonly struct LoadedWfConfig : IWfEvent<LoadedWfConfig>
    {        
        public WfEventId Id {get;}
        
        public AppMsgColor Flair {get;}
        
        public readonly FilePath ConfigPath;

        public readonly WfConfig ConfigData;

        [MethodImpl(Inline)]
        public LoadedWfConfig(WfEventId id, FilePath src, WfConfig data)
        {
            Id = id;
            Flair = DefaultFlair;
            ConfigPath = src;
            ConfigData = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id, ConfigPath);        
    }
}