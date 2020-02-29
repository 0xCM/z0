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

    public readonly struct Sink<A,B> : ISink<A,B>
    {
        static void empty(in A a, in B b){}
        
        public static Sink<A,B> Empty => new Sink<A,B>(empty);

        readonly SinkReceiver<A,B> Receiver;
        
        [MethodImpl(Inline)]
        internal Sink(SinkReceiver<A,B> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Accept(in A a, in B b)
            => Receiver(in a, in b);
    }

    public readonly struct Sink<A,B,C> : ISink<A,B,C>
    {
        static void empty(in A a, in B b, in C c){}
        
        public static Sink<A,B,C> Empty => new Sink<A,B,C>(empty);

        readonly SinkReceiver<A,B,C> Receiver;
        
        [MethodImpl(Inline)]
        internal Sink(SinkReceiver<A,B,C> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Accept(in A a, in B b, in C c)
            => Receiver(in a, in b, in c);
    }
}