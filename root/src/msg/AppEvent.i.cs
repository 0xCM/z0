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

    public delegate void AppEventReceiver(IAppEvent @event);

    public delegate void AppEventReceiver<E>(E @event)
        where E : IAppEvent;
        

    public interface IAppEvent : ICustomFormattable
    {
        string EventName {get;}

        object EventData {get;}

        string ICustomFormattable.Format()        
            => text.concat(EventName, text.colon(), text.space(), EventData?.ToString() ?? string.Empty);  

        IAppEvent<K> As<K>()
            => AppEvent.Create<K>(EventName, (K)EventData);
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

        string IAppEvent.EventName
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

}