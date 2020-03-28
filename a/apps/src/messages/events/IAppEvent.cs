//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAppEvent : ICorrelated, ICustomFormattable
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
    public interface IAppEvent<T> : IAppEvent
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

    public interface IAppEventChannel<E> : IAppEventSource<E>, IAppEventSink<E>
        where E : IAppEvent
    {

    }
}