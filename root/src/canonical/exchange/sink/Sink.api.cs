//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class Sink
    {
        /// <summary>
        /// Creates a singleton value sink predicated on a supplied delegate receiver
        /// </summary>
        /// <param name="dst">The delegate receiver</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static ISink<A> Create<A>(SinkReceiver<A> dst)
            => new Sink<A>(dst);

        /// <summary>
        /// Creates a pair value sink predicated on a supplied delegate receiver
        /// </summary>
        /// <param name="dst">The delegate receiver</param>
        /// <typeparam name="A">The first member type</typeparam>
        /// <typeparam name="B">The second member type</typeparam>
        [MethodImpl(Inline)]
        public static ISink<A,B> Create<A,B>(SinkReceiver<A,B> dst)
            => new Sink<A,B>(dst);

        /// <summary>
        /// Creates a triple value sink predicated on a supplied delegate receiver
        /// </summary>
        /// <param name="dst">The delegate receiver</param>
        /// <typeparam name="A">The first member type</typeparam>
        /// <typeparam name="B">The second member type</typeparam>
        /// <typeparam name="C">The third member type</typeparam>
        [MethodImpl(Inline)]
        public static ISink<A,B,C> Create<A,B,C>(SinkReceiver<A,B,C> dst)
            => new Sink<A,B,C>(dst);

        [MethodImpl(Inline)]
        public static ISink<T> ToSink<T>(this SinkReceiver<T> dst)
            => Create(dst);

        [MethodImpl(Inline)]
        public static ISink<A,B> ToSink<A,B>(this SinkReceiver<A,B> dst)
            => Create(dst);
    
        /// <summary>
        /// Creates a sink that does no work
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static Sink<T> Empty<T>()                
            => Sink<T>.Empty;

        /// <summary>
        /// Creates a pair sink that does no work
        /// </summary>
        /// <typeparam name="A">The first member type</typeparam>
        /// <typeparam name="B">The second member type</typeparam>
        [MethodImpl(Inline)]
        public static Sink<A,B> Empty<A,B>()                
            => Sink<A,B>.Empty;

        /// <summary>
        /// Creates a triple sink that does no work
        /// </summary>
        /// <typeparam name="A">The first member type</typeparam>
        /// <typeparam name="B">The second member type</typeparam>
        /// <typeparam name="C">The third member type</typeparam>
        [MethodImpl(Inline)]
        public static Sink<A,B,C> Empty<A,B,C>()                
            => Sink<A,B,C>.Empty;
    }
}