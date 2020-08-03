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

    public readonly struct WfStepFinished<T> : IWfEvent<WfStepFinished<T>, T>
    {
        public WfEventId Id {get;}
        
        public T Payload {get;}

        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public WfStepFinished(string worker, T detail, CorrelationToken ct)
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