//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a sink that forwards deposits to a receiver
    /// </summary>
    public readonly struct EncodedEventRelay<E> : IEncodedEventSink<E>
        where E : struct, IAppEvent
    {
        readonly HubEventReceiver<E> Receiver;

        [MethodImpl(Inline)]
        public EncodedEventRelay(HubEventReceiver<E> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Deposit(in E e)
            => Receiver(e);

        void IEventHubSink.Deposit(IAppEvent e)
            => Deposit((E)e);
    }
}