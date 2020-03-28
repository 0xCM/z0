//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static SFuncs;

    public readonly struct Sink<T> : ISink<T>
    {
        static void empty(in T src){}
        
        public static Sink<T> Empty => new Sink<T>(empty);
        
        readonly Receiver<T> Receiver;
        
        [MethodImpl(Inline)]
        internal Sink(Receiver<T> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Accept(in T src)
            => Receiver(in src);
    }
}