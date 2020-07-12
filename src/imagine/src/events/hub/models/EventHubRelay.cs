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
    public readonly struct EventHubRelay : IEventHubSink
    {
        readonly HubEventReceiver Receiver;

        [MethodImpl(Inline)]
        public EventHubRelay(HubEventReceiver receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Deposit(IAppEvent e)
            => Receiver(e);
    }
}