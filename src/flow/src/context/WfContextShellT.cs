//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;

    public readonly struct WfContextShell<T> : IWfContext<T>
    {
        public IAppContext ContextRoot {get;}

        public IWfEventSink Sink {get;}
        
        public T ContextData {get;}
             
        public string AppName
            => ContextRoot.AppPaths.AppName;

        [MethodImpl(Inline)]
        public WfContextShell(IAppContext root, T data, IWfEventSink sink)
        {
            ContextRoot = root;
            ContextData = data;
            Sink = sink;
            Sink.Deposit(new WfStepRunning($"ContextShellLoader[{typeof(T).Name}]"));
        }

        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
        {
            Sink.Deposit(@event);
            return @event.Id;
        }

        public void Dispose()
        {
            Sink.Deposit(new WfStepFinished($"ContextShellLoader[{typeof(T).Name}]"));
        }
    }
}