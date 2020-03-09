//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    public interface IWorkflow : IAsmService
    {
        
    }

    public interface IWorkflow<W> : IWorkflow
    {


    }

    public interface IAppEventBroker
    {
        void AcceptSink<S,E>(S sink, E model = default)
            where E : IAppEvent
            where S : IAppEventSink<E>;

        void AcceptReceiver<E>(Action<E> receiver, E model = default)
            where E : IAppEvent;        
    }

    public static class AppEventBrokerOps
    {
        [MethodImpl(Inline)]
        public static void Receive<E>(this E e, IAppEventBroker broker, Action<E> receiver)
            where E : IAppEvent
                => broker.AcceptReceiver(receiver);
        
        [MethodImpl(Inline)]
        public static EventPredicate<E> ToPredicate<E>(this E e, bit eval)
            where E : IAppEvent
                => new EventPredicate<E>(eval);
    }

    public interface IAppEventRelay : IAppEventBroker
    {
        void RaiseEvent<E>(in E e)
            where E : IAppEvent;
    }


    public readonly struct EventPredicate<E> 
        where E : IAppEvent
    {
        [MethodImpl(Inline)]
        public static bool operator true(EventPredicate<E> src)
            => src.Evaluation;

        [MethodImpl(Inline)]
        public static bool operator false(EventPredicate<E> src)
            => !src.Evaluation;

        [MethodImpl(Inline)]
        public EventPredicate(bit evaluation)
        {
            this.Evaluation = evaluation;
        }
        
        public readonly bit Evaluation;
        
    }
}