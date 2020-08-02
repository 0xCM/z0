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

    public readonly struct WorkerInitialized : IWfEvent<WorkerInitialized>
    {        
        const string Pattern = "{0}: Initialized";
        
        public WfEventId Id {get;}
        
        [MethodImpl(Inline)]
        public WorkerInitialized(string worker, CorrelationToken? ct = null)
        {
            Id = WfEventId.define(worker, ct ?? CorrelationToken.create(), now());        
        }

        public AppMsgColor Flair 
            => AppMsgColor.Magenta;

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id);
    }
}