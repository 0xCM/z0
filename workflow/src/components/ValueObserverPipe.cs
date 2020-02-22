//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;
    
    readonly struct ValueObserverPipe<T> : IValueObserverPipe<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public static ValueObserverPipe<T> Create(PointReceiver<T> receiver)
            => new ValueObserverPipe<T>(receiver);
                
        [MethodImpl(Inline)]
        ValueObserverPipe(PointReceiver<T> receiver)
            => this.Receiver = receiver;
        
        public readonly PointReceiver<T> Receiver {get;}
    }
}