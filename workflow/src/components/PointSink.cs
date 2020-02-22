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

    public readonly struct PointSink<T> : IPointSink<T>
    {
        static void empty(in T src){}
        
        public static PointSink<T> Empty => new PointSink<T>(empty);
        
        readonly PointReceiver<T> Receiver;
        
        [MethodImpl(Inline)]
        internal PointSink(PointReceiver<T> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Accept(in T src)
            => Receiver(in src);
    }

    public readonly struct PointSink<A,B> : IPointSink<A,B>
    {
        static void empty(in A a, in B b){}
        
        public static PointSink<A,B> Empty => new PointSink<A,B>(empty);

        readonly PointReceiver<A,B> Receiver;
        
        [MethodImpl(Inline)]
        internal PointSink(PointReceiver<A,B> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Accept(in A a, in B b)
            => Receiver(in a, in b);
    }

    public readonly struct PointSink<A,B,C> : IPointSink<A,B,C>
    {
        static void empty(in A a, in B b, in C c){}
        
        public static PointSink<A,B,C> Empty => new PointSink<A,B,C>(empty);

        readonly PointReceiver<A,B,C> Receiver;
        
        [MethodImpl(Inline)]
        internal PointSink(PointReceiver<A,B,C> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Accept(in A a, in B b, in C c)
            => Receiver(in a, in b, in c);
    }

}