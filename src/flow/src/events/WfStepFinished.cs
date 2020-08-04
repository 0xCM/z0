//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static Flow;
    using static WfStepFinishedEvent;

    [Event(true)]
    public readonly struct WfStepFinishedEvent
    {
        public const string DefaultPattern = IdMarker + "Completed";

        public const string DetailPattern = IdMarker + "Completed" + ContentMarker;

        public const AppMsgColor DefaultFlair = AppMsgColor.Cyan;
    }

    [Event]
    public readonly struct WfStepFinished : IWfEvent<WfStepFinished>
    {
        public readonly WfEventId Id {get;}

        public readonly string Detail;

        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public WfStepFinished(string worker, CorrelationToken? ct = null)
        {
            Id = wfid(worker, ct);
            Detail = EmptyString;
            Flair = DefaultFlair;
        }

        [MethodImpl(Inline)]
        public WfStepFinished(string worker, string detail, CorrelationToken? ct = null)
        {
            Id = wfid(worker, ct);
            Detail = detail;
            Flair = DefaultFlair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.nonempty(Detail) 
            ? text.format(DetailPattern, Id, Detail)
            : text.format(DefaultPattern, Id);            
    }
}