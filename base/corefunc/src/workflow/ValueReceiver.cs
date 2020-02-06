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

    public delegate void SpanReceiver<T>(Span<T> src);

    public delegate void StreamReceiver<T>(IEnumerable<T> src);

    public delegate void PointReceiver<T>(in T src);

    public delegate void PointReceiver<A,B>(in A a, in B b);

    public delegate void PointReceiver<A,B,C>(in A a, in B b, in C c);

    public interface ISink
    {

    }

    public interface IPointSink<T> : ISink
    {
        void Accept(in T src);
    }

    public interface IBufferedPointSink<S,T> : ISink
    {
        void Accept(in S src, Span<T> buffer);
    }

    public interface IPointSink<A,B> : ISink
    {
        void Accept(in A a, in B b);
    }

    public interface IPointSink<A,B,C> : ISink
    {
        void Accept(in A a, in B b, in C c);
    }

    public interface IStreamSink<T> : ISink
    {
        void Accept(IEnumerable<T> src);
    }

    public interface ISpanSink<T> : ISink
    {
        void Accept(Span<T> src);
    }

    public static class PointSinks
    {
        /// <summary>
        /// Creates a singleton value sink predicated on a supplied delegate receiver
        /// </summary>
        /// <param name="dst">The delegate receiver</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static PointSink<T> Create<T>(PointReceiver<T> dst)                
            => new PointSink<T>(dst);


        /// <summary>
        /// Creates a pair value sink predicated on a supplied delegate receiver
        /// </summary>
        /// <param name="receiver">The delegate receiver</param>
        /// <typeparam name="A">The first member type</typeparam>
        /// <typeparam name="B">The second member type</typeparam>
        [MethodImpl(Inline)]
        public static PointSink<A,B> Create<A,B>(PointReceiver<A,B> receiver)                
            => new PointSink<A,B>(receiver);

        /// <summary>
        /// Creates a triple value sink predicated on a supplied delegate receiver
        /// </summary>
        /// <param name="receiver">The delegate receiver</param>
        /// <typeparam name="A">The first member type</typeparam>
        /// <typeparam name="B">The second member type</typeparam>
        /// <typeparam name="C">The third member type</typeparam>
        [MethodImpl(Inline)]
        public static PointSink<A,B,C> Create<A,B,C>(PointReceiver<A,B,C> receiver)                
            => new PointSink<A,B,C>(receiver);

        [MethodImpl(Inline)]
        public static PointSink<T> ToPointSink<T>(this PointReceiver<T> dst)
            => Create(dst);

        [MethodImpl(Inline)]
        public static PointSink<A,B> ToPointSink<A,B>(this PointReceiver<A,B> dst)
            => Create(dst);

        /// <summary>
        /// Creates a point sink that does no work
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static PointSink<T> Empty<T>()                
            => PointSink<T>.Empty;

        /// <summary>
        /// Creates a pair value sink that does no work
        /// </summary>
        /// <typeparam name="A">The first member type</typeparam>
        /// <typeparam name="B">The second member type</typeparam>
        [MethodImpl(Inline)]
        public static PointSink<A,B> Empty<A,B>()                
            => PointSink<A,B>.Empty;

        /// <summary>
        /// Creates a triple value sink that does no work
        /// </summary>
        /// <typeparam name="A">The first member type</typeparam>
        /// <typeparam name="B">The second member type</typeparam>
        /// <typeparam name="C">The third member type</typeparam>
        [MethodImpl(Inline)]
        public static PointSink<A,B,C> Empty<A,B,C>()                
            => PointSink<A,B,C>.Empty;
    }

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

    public readonly struct SpanSink<T> : ISpanSink<T>
    {
        readonly SpanReceiver<T> Receiver;
        
        [MethodImpl(Inline)]
        internal SpanSink(SpanReceiver<T> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Accept(Span<T> src)
            => Receiver(src);
    }

}