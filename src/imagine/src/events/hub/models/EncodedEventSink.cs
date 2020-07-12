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

    public readonly struct EncodedEventSink<E> : IEncodedEventSink<E>
        where E : struct, IAppEvent
    {
        readonly HubEventReceiver<E> Receiver;

        [MethodImpl(Inline)]
        public EncodedEventSink(HubEventReceiver<E> receiver)
            => Receiver = receiver;

        [MethodImpl(Inline)]
        public void Deposit(in E src)
            => Receiver(src);
    }
}