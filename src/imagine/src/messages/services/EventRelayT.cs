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
    public readonly struct EventRelay<E> : IAppEventSink<E>
        where E : IAppEvent
    {
        readonly Action<E> Receiver;

        [MethodImpl(Inline)]
        internal EventRelay(Action<E> receiver)
        {
            this.Receiver = receiver;
        }
        
        [MethodImpl(Inline)]
        public void Deposit(E e)
            => Receiver(e);
    }
}