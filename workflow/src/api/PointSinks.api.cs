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
}