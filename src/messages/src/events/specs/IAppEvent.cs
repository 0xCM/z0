//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a correlated message, accompanied by arbitrary content, that describes something that occurred
    /// within the system
    /// </summary>
    public interface IAppEvent : ICorrelated, ICustomFormattable
    {
        /// <summary>
        /// The data associated with the event
        /// </summary>
        object Payload {get;}

        string Description {get;}

        string ICustomFormattable.Format()        
            => text.concat(Description, text.colon(), text.space(), Payload?.ToString() ?? string.Empty);  

        IAppEvent<K> As<K>()
            => AppEvent.Create<K>(Description, (K)Payload);

        Outcome Subscribe(IAppEventBroker broker, Action<IAppEvent> receiver)
            => AppEvents.subscribe(this, broker, receiver);

    }

    /// <summary>
    /// Characterizes an application event with a parametric payload
    /// </summary>
    /// <typeparam name="T">The payload type</typeparam>
    public interface IAppEvent<T> : IAppEvent
    {
        new T Payload {get;}

        object IAppEvent.Payload
            => Payload;                
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic payload-parametric application event reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="T">The payload type</typeparam>
    public interface IAppEvent<F,T> : IAppEvent<T>, INullary<F>
        where F : struct, IAppEvent<F,T>
    {
        string IAppEvent.Description
            => typeof(F).DisplayName();

        string ICustomFormattable.Format()        
            => Description;                        
    }
}