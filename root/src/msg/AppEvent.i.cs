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


    public interface IAppEvent : ICustomFormattable
    {
        object EventData {get;}

        string Description {get;}

        string ICustomFormattable.Format()        
            => text.concat(Description, text.colon(), text.space(), EventData?.ToString() ?? string.Empty);  

        IAppEvent<K> As<K>()
            => AppEvent.Create<K>(Description, (K)EventData);
    }

    /// <summary>
    /// Characterizes an system event with a parametric payload
    /// </summary>
    /// <typeparam name="T">The payload type</typeparam>
    public interface IAppEvent<T> : IAppEvent, IFormattable<T>
    {
        new T EventData {get;}

        object IAppEvent.EventData
            => EventData;                
    }

    public interface IAppEvent<E,T> : IAppEvent<T>
        where E : IAppEvent<E,T>
    {
        string IAppEvent.Description
            => typeof(E).DisplayName();
    }



    public interface IAppEventSink : ISink
    {

    }

    public interface IAppEventSink<E> : IAppEventSink, ISink<E>
        where E : IAppEvent
    {

    }

    public interface IAppEventSink<S,E> : IAppEventSink<E>
        where S : IAppEventSink<S,E>
        where E : IAppEvent
    {

        
    }

    public readonly struct AppEventReceiverSink
    {
        [MethodImpl(Inline)]
        public static AppEventReceiverSink<E> From<E>(Action<E> receiver)
            where E : IAppEvent
                => new AppEventReceiverSink<E>(receiver);
    }


    public readonly struct AppEventReceiverSink<E> : IAppEventSink<E>
        where E : IAppEvent
    {
        readonly Action<E> Receiver;

        [MethodImpl(Inline)]
        internal AppEventReceiverSink(Action<E> receiver)
        {
            this.Receiver = receiver;
        }
        
        [MethodImpl(Inline)]
        public void Accept(in E e)
            => Receiver(e);
    }

    public delegate IAppEvent AppEventEmitter();

    public delegate E AppEventEmitter<E>()
        where E : IAppEvent;        

    public interface IAppEventSource : ISource
    {

    }

    public interface IAppEventSource<E> : IAppEventSource
        where E : IAppEvent
    {
        void AcceptReceiver(Action<E> receiver);
    }

    public interface IAppEventSource<S,E> : IAppEventSource<E>
        where S : IAppEventSource<S,E>
        where E : IAppEvent
    {
        
    }

    public interface IAppEventChannel<E> : IAppEventSource<E>, IAppEventSink<E>
        where E : IAppEvent
    {

    }
}