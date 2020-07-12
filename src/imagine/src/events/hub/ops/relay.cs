//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    partial struct EventHubs
    {
        [MethodImpl(Inline), Op]
        public static EventHubRelay relay(HubEventReceiver receiver)
            => new EventHubRelay(receiver);

        [MethodImpl(Inline), Op]
        public static EncodedEventRelay relay(EncodedEventReceiver receiver)
            => new EncodedEventRelay(receiver);

        [MethodImpl(Inline)]
        internal static EncodedEventRelay<E> relay<E>(HubEventReceiver<E> receiver)
            where E : struct, IAppEvent
                => new EncodedEventRelay<E>(receiver);
    }
}