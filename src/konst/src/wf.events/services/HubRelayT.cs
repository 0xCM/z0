//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a sink that forwards deposits to a receiver
    /// </summary>
    public readonly struct HubRelay<E> : IDataEventSink
        where E : struct, IDataEvent
    {
        readonly EventReceiver<E> Receiver;

        [MethodImpl(Inline)]
        internal HubRelay(EventReceiver<E> receiver)
            => Receiver = receiver;

        [MethodImpl(Inline)]
        public void Deposit(in E e)
            => Receiver(e);

        public void Deposit(IDataEvent e)
            => Receiver((E)e);
    }
}