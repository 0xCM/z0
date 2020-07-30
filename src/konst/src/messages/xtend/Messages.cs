//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial class XTend
    {
        public static IAppMsgLog MessageLog(this TAppEnv env)
            => AppMsgLog.Create(env);        

        [MethodImpl(Inline)]
        public static Outcome Subscribe(this IAppEvent e, IEventBroker broker, Action<IAppEvent> receiver)
            => Z0.Events.subscribe(e, broker, receiver);

        /// <summary>
        /// Registers an event receiver to which brokered events will be relayed
        /// </summary>
        /// <param name="e">An event representative</param>
        /// <param name="broker">The broker</param>
        /// <param name="receiver">The handler ivoked upon event occurrence</param>
        /// <typeparam name="E">The event type</typeparam>
        [MethodImpl(Inline)]
        public static Outcome Subscribe<E>(this E e, IEventBroker broker, Action<E> receiver)
            where E : IAppEvent
                => Z0.Events.subscribe(e, broker, receiver);

        public static ref readonly E Deposit<E>(this IAppMsgSink dst, in E src)      
            where E : IAppEvent
        {
            dst.NotifyConsole(src.Message);
            return ref src;
        }
    }
}