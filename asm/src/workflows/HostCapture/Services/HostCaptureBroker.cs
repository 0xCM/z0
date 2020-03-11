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
        sealed class HostCaptureBroker : IHostCaptureEventBroker
        {
            public IAsmWorkflowContext Context {get;}
            
            readonly Dictionary<Type, IAppEventSink> Sinks;
                        
            [MethodImpl(Inline)]
            internal static IHostCaptureEventBroker Create(IAsmWorkflowContext context)
                => new HostCaptureBroker(context);            

            HostCaptureBroker(IAsmWorkflowContext context)
            {
                this.Sinks = new Dictionary<Type, IAppEventSink>();
                this.Context = context;
            }

            BrokerAcceptance<E> AcceptSink<S,E>(S sink, E model)
                where E : IAppEvent
                where S : IAppEventSink
            {
                if(Sinks.TryAdd(typeof(E), sink))
                    return true;
                else
                    return (false, AppMsg.Warn($"Key for {model} was previously specified added for {sink}"));
            }
            
            BrokerAcceptance<E> IAppEventBroker.AcceptSink<S, E>(S sink, E model)
                => AcceptSink(sink,model);

            public BrokerAcceptance<E> AcceptReceiver<E>(Action<E> receiver, E model = default)
                where E : IAppEvent                 
            {
                var sink = AppEventReceiverSink.From(receiver);
                return AcceptSink(sink,model);
            }

            ref readonly E IAppEventRelay.RaiseEvent<E>(in E e)
            {                
                if(Sinks.TryGetValue(e.GetType(), out var sink))
                {
                    ((IAppEventSink<E>)sink).Accept(e);
                }
                return ref e;
            }
       }
    }
}