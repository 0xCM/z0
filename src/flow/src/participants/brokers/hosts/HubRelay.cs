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
    public readonly struct HubRelay : IDataSink
    {
        readonly EventReceiver Receiver;

        [MethodImpl(Inline)]
        public HubRelay(EventReceiver receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Deposit(IDataEvent e)
            => Receiver(e);

        [MethodImpl(Inline)]
        public void Deposit<S>(in S e)
            where S : struct, IDataEvent
                => Receiver(e);
    }
}