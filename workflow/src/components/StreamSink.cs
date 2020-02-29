//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct StreamSink<T> : IStreamSink<T>
    {
        static void empty(IEnumerable<T> src){}        
        
        public static IStreamSink<T> Empty => new StreamSink<T>(empty);

        readonly StreamReceiver<T> Receiver;
        
        [MethodImpl(Inline)]
        internal StreamSink(StreamReceiver<T> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Accept(IEnumerable<T> src)
            => Receiver(src);
    }
}