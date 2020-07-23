//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;


    [ApiHost]
    public readonly struct Events
    {
        /// <summary>
        /// Creates an informational event
        /// </summary>
        /// <param name="id">The event identifier</param>
        /// <param name="description">The event description</param>
        [MethodImpl(Inline), Op]
        public static AppEvent create(StringRef id, string description, AppMsgColor flair = AppMsgColor.Blue)
            => new AppEvent(id,description,flair);

        /// <summary>
        /// Creates an error event
        /// </summary>
        /// <param name="content">The event content</param>
        [MethodImpl(Inline)]
        public static AppErrorEvent error(object content)
            => new AppErrorEvent(AppMsg.NoCaller(content, AppMsgKind.Error));
            
        /// <summary>
        /// Creates an even sink predicated on a receiver
        /// </summary>
        /// <param name="receiver">The receiver to invoke upon event receipt</param>
        /// <typeparam name="E">The event type</typeparam>
        [MethodImpl(Inline)]
        public static EventRelay<E> sink<E>(Action<E> receiver)
            where E : IAppEvent
                => new EventRelay<E>(receiver);

        /// <summary>
        /// Creates an even sink predicated on a receiver
        /// </summary>
        /// <param name="receiver">The receiver to invoke upon event receipt</param>
        /// <typeparam name="E">The event type</typeparam>
        [MethodImpl(Inline)]
        public static EventRelay sink(Action<IAppEvent> receiver)
            => new EventRelay(receiver);

        /// <summary>
        /// Registers an event receiver to which brokered events will be relayed
        /// </summary>
        /// <param name="model">An event representative</param>
        /// <param name="broker">The broker</param>
        /// <param name="receiver">The handler ivoked upon event occurrence</param>
        /// <typeparam name="E">The event type</typeparam>
        [MethodImpl(Inline)]
        public static Outcome subscribe<E>(E model, IEventBroker broker, Action<E> receiver)
            where E : IAppEvent
                => broker.Subscribe(receiver);        
        
        [MethodImpl(Inline)]
        public static Outcome subscribe(IAppEvent model, IEventBroker broker, Action<IAppEvent> receiver)
            => broker.Subscribe(receiver, model);
    }
}