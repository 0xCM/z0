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
        [MethodImpl(Inline)]
        internal static ref readonly E broadcast<E>(EventHub hub, in E e)
            where E : struct, IAppEvent                 
        {                
            if(hub.Index.TryGetValue(e.GetType(), out var sink))
                ((IEncodedEventSink<E>)sink).Deposit(e);
            return ref e;
        }
    }
}