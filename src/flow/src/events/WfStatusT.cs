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
    using static z;

    [Event]
    public readonly struct WfStatus<T> : IWfEvent<WfStatus<T>>
    {        
        const string Pattern = IdMarker + "{1} | {2}";

        public WfEventId Id {get;}

        public AppMsgColor Flair {get;}

        public string WorkerName {get;}
        
        public T Body {get;}

        [MethodImpl(Inline)]
        public WfStatus(string worker, T body, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Blue)
        {
            Id = wfid(nameof(WfStatus),  ct);
            Flair =  flair;
            WorkerName = worker;
            Body = body;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id, WorkerName, Body);
    }
}