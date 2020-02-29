//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    
    readonly struct ValueObserverPipe<T> : IValueObserverPipe<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public static ValueObserverPipe<T> Create(SinkReceiver<T> receiver)
            => new ValueObserverPipe<T>(receiver);
                
        [MethodImpl(Inline)]
        ValueObserverPipe(SinkReceiver<T> receiver)
            => this.Receiver = receiver;
        
        public readonly SinkReceiver<T> Receiver {get;}
    }
}