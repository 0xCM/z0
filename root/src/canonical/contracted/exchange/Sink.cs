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

    using static Root;

    public readonly struct Sink<T> : ISink<T>
    {
        static void empty(in T src){}
        
        public static Sink<T> Empty => new Sink<T>(empty);
        
        readonly SinkReceiver<T> Receiver;
        
        [MethodImpl(Inline)]
        internal Sink(SinkReceiver<T> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Accept(in T src)
            => Receiver(in src);
    }


}