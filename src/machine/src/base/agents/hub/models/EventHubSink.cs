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

    public readonly struct EventHubSink : IEventHubSink
    {
        readonly HubEventReceiver Receiver;

        [MethodImpl(Inline)]
        public EventHubSink(HubEventReceiver receiver)
            => Receiver = receiver;

        [MethodImpl(Inline)]
        public void Deposit(IAppEvent e)
            => Receiver(e);
    }
}