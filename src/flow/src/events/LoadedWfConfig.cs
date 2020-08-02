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

    public readonly struct LoadedWfConfig : IWfEvent<LoadedWfConfig>
    {
        const string Pattern = IdMarker + "Comleted workflow load from {1}";
        
        public WfEventId Id {get;}

        public readonly FilePath ConfigPath;

        public readonly WfConfig ConfigData;

        [MethodImpl(Inline)]
        public LoadedWfConfig(WfEventId id, FilePath src, WfConfig data)
        {
            Id = id;
            ConfigPath = src;
            ConfigData = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id, ConfigPath);        
    }
}