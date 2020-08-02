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

    public readonly struct WorkerCreated : IWfEvent<WorkerCreated>
    {        
        const string Pattern = IdMarker + "Created";

        public WfEventId Id {get;}

        public AppMsgColor Flair {get;}

        public string WorkerName {get;}
        
        [MethodImpl(Inline)]
        public WorkerCreated(string worker, CorrelationToken? ct = null, AppMsgColor flair = AppMsgColor.Magenta)
        {
            WorkerName = worker;
            Id = wfid(worker, ct);
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id);
    }
}