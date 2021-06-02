//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public abstract class ProcessService<T> : ProcessService
    {
        protected ProcessService(IEventSink sink)
            : base(sink)
        {
            Receiver = Receive;
        }

        protected ProcessService(IEventSink sink, Receiver<T> receiver)
            :base(sink)
        {
            Receiver = receiver;
        }

        protected Receiver<T> Receiver {get;}

        protected virtual void Receive(in T src)
        {

        }
    }
}