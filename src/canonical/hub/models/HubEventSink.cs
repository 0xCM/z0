//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Konst;


    [SuppressUnmanagedCodeSecurity]
    public delegate void HubEventReceiver(IAppEvent e);

    [SuppressUnmanagedCodeSecurity]
    public delegate void DataEventReceiver(IDataEvent e);

    [SuppressUnmanagedCodeSecurity]
    public delegate void HubEventReceiver<E>(in E e)
        where E : struct, IAppEvent;

    public readonly struct HubEventSink : IHubEventSink
    {
        readonly HubEventReceiver Receiver;

        [MethodImpl(Inline)]
        public HubEventSink(HubEventReceiver receiver)
            => Receiver = receiver;

        [MethodImpl(Inline)]
        public void Deposit(IAppEvent e)
            => Receiver(e);
    }
    
    public readonly struct HubEventSink<E> : IHubEventSink<E>
        where E : struct, IAppEvent
    {
        readonly HubEventReceiver<E> Receiver;

        [MethodImpl(Inline)]
        public HubEventSink(HubEventReceiver<E> receiver)
            => Receiver = receiver;

        [MethodImpl(Inline)]
        public void Deposit(in E src)
            => Receiver(src);
    }
}