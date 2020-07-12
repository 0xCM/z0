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
    public readonly struct EncodedEventRelay : IEncodedEventSink
    {
        readonly EncodedEventReceiver Receiver;

        [MethodImpl(Inline)]
        public EncodedEventRelay(EncodedEventReceiver receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Deposit(IEncodedEvent e)
            => Receiver(e);
    }
}