//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    public interface IWorkerContext
    {
        IEncodedEventSink Sink {get;}
    }

    public readonly struct WorkerContext
    {
        public IEncodedEventSink Sink {get;}        

        [MethodImpl(Inline)]
        public WorkerContext(IEncodedEventSink sink)
        {
            Sink = sink;
        }        
    }
}