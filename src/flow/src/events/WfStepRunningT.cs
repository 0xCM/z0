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
    using static WfStepRunningEvent;

    public readonly struct WfStepRunning<T> : IWfEvent<WfStepRunning<T>, T>
    {
        public WfEventId Id {get;}
        
        public T Payload {get;}

        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public WfStepRunning(string worker, T detail, CorrelationToken ct)
        {
            Id = wfid(worker, ct);
            Payload = detail;
            Flair = DefaultFlair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(DetailPattern, Id, Payload);          
    }   
}