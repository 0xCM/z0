//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;


    using static Konst;
    
    readonly struct ValueObserverPipe<T> : IValueObserverPipe<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public static ValueObserverPipe<T> Create(Receiver<T> receiver)
            => new ValueObserverPipe<T>(receiver);
                
        [MethodImpl(Inline)]
        ValueObserverPipe(Receiver<T> receiver)
            => this.Receiver = receiver;
        
        public readonly Receiver<T> Receiver {get;}
    }
}