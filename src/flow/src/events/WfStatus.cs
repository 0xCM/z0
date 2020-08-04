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
    using static z;
    
    [Event]
    public readonly struct WfStatus : IWfEvent<WfStatus>
    {        
        const string Pattern = IdMarker + "{1} | {2}";

        public WfEventId Id {get;}

        public AppMsgColor Flair {get;}

        public readonly string Message;

        public string WorkerName {get;}
 
        [MethodImpl(Inline)]
        public WfStatus(string worker, string msg, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Blue)
        {
            Id = wfid(nameof(WfStatus), ct);
            Flair =  flair;
            Message = msg;
            WorkerName = worker;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id, WorkerName, Message);
    }
}