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

        public const string Pattern = "Opening workflow context | {0}";
        
        public const AppMsgColor DefaultFlair = AppMsgColor.Magenta;

        public WfEventId Id {get;}

        public string ActorName {get;}
        
        public string Body {get;}

        public AppMsgColor Flair {get;}
        
        public AppMsg Description {get;}

        [MethodImpl(Inline)]
        public OpeningWfContext(string worker, string type, CorrelationToken ct, AppMsgColor flair = DefaultFlair)
        {
            Id = wfid(EventName, ct);
            ActorName = worker;
            Body = type;
            Flair = flair;
            Description = AppMsg.Colorize(text.format(Pattern, Body), Flair);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, Id, ActorName, Description);        
    }
}