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
    public readonly struct WorkerInitialized : IWfEvent<WorkerInitialized>
    {        
        const string Pattern = PSx2;
        
        public WfEventId Id {get;}
        
        public string WorkerName {get;}
        
        [MethodImpl(Inline)]
        public WorkerInitialized(string worker, CorrelationToken ct)
        {
            Id = wfid(nameof(WorkerInitialized), ct);
            WorkerName = worker;
        }
        public AppMsgColor Flair 
            => AppMsgColor.Magenta;

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id, WorkerName);
    }
}