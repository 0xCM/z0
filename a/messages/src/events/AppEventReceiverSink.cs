//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

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
}