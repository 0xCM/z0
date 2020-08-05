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
        public const string EventName = nameof(LoadingWfConfig);

        public const string EventMsg = "Loading workflow configuration | {0}";
        
        public const AppMsgColor DefaultFlair = AppMsgColor.Magenta;
        
        public WfEventId Id {get;}

        public string ActorName {get;}
        
        public FilePath Body {get;}
        
        public AppMsgColor Flair {get;}
        
        public AppMsg Description {get;}

        [MethodImpl(Inline)]
        public LoadingWfConfig(string worker, FilePath body, CorrelationToken ct, AppMsgColor flair = DefaultFlair)
        {
            Id = wfid(EventName, ct);
            ActorName = worker ?? "anonymous";
            Body = body;
            Flair = flair;
            Description = AppMsg.Colorize(text.format(EventMsg, Body), Flair);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, Id, ActorName, Description);            }
}