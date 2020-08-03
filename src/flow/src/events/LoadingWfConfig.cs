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
    public readonly struct LoadingWfConfig : IWfEvent<LoadingWfConfig>
    {
        const string Pattern = IdMarker + "Loading workflow configuration from {1}";
        
        public WfEventId Id {get;}

        public readonly FilePath ConfigPath;

        [MethodImpl(Inline)]
        public LoadingWfConfig(WfEventId id, FilePath src)
        {
            Id = id;
            ConfigPath = src;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id, ConfigPath);        
    }
}