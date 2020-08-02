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
    using static z;

    public readonly struct WorkerFinished : IWfEvent<WorkerFinished>
    {        
        const string Pattern = "{0}: Finished";

        public WfEventId Id {get;}

        public AppMsgColor Flair {get;}

        public string WorkerName {get;}
        
        [MethodImpl(Inline)]
        public WorkerFinished(string worker, CorrelationToken? ct = null, AppMsgColor flair = AppMsgColor.Cyan)
        {
            WorkerName = worker;
            Id = WfEventId.define(worker, ct ?? CorrelationToken.create(), now());
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id);
    }
}