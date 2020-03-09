//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    partial class HostCaptureWorkflow
    {        
        sealed class EventBroker : IWorkflowEventRelay
        {
            readonly Dictionary<Type, IAppEventSink> Sinks;
            
            readonly IAppEventRelay Broker;
            
            [MethodImpl(Inline)]
            internal static EventBroker Connect(WorkflowRunner workflow)
                => new EventBroker(workflow);            

            EventBroker(WorkflowRunner workflow)
            {
                this.Sinks = new Dictionary<Type, IAppEventSink>();
                this.Broker = this;
            }

            void IAppEventBroker.AcceptSink<S, E>(S sink, E model)
            {
                 Sinks[typeof(E)] = sink;
            }

            public void AcceptReceiver<E>(Action<E> receiver, E model = default)
                where E : IAppEvent                 
            {
                Sinks[typeof(E)] = AppEventReceiverSink.From(receiver);
            }

            void IAppEventRelay.RaiseEvent<E>(in E e)
            {                
                if(Sinks.TryGetValue(e.GetType(), out var sink))
                {
                    ((IAppEventSink<E>)sink).Accept(e);
                }
            }
       }
    }
}