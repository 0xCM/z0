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
    public readonly struct HubRelay : IHubEventSink
    {
        readonly HubEventReceiver Receiver;

        [MethodImpl(Inline)]
        public HubRelay(HubEventReceiver receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Deposit(IAppEvent e)
            => Receiver(e);
    }

    /// <summary>
    /// Defines a sink that forwards deposits to a receiver
    /// </summary>
    public readonly struct HubDataRelay : IDataEventSink
    {
        readonly DataEventReceiver Receiver;

        [MethodImpl(Inline)]
        public HubDataRelay(DataEventReceiver receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Deposit(IDataEvent e)
            => Receiver(e);
    }

    /// <summary>
    /// Defines a sink that forwards deposits to a receiver
    /// </summary>
    public readonly struct HubRelay<E> : IHubEventSink<E>
        where E : struct, IAppEvent
    {
        readonly HubEventReceiver<E> Receiver;

        [MethodImpl(Inline)]
        public HubRelay(HubEventReceiver<E> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Deposit(in E e)
            => Receiver(e);

        void IHubEventSink.Deposit(IAppEvent e)
            => Deposit((E)e);
    }
}