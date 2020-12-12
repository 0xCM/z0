//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;

    partial struct Pipes
    {
        [Op, Closures(Closure)]
        public static Pipe<T> pipe<T>()
            => pipe(new ConcurrentBag<T>());

        public static Pipe<S,T> pipe<S,T>()
            => pipe<S,T>(new ConcurrentBag<S>());

        [MethodImpl(Inline)]
        internal static Pipe<S,T> pipe<S,T>(ConcurrentBag<S> buffer)
            => new Pipe<S,T>(buffer);

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static Pipe<T> pipe<T>(ConcurrentBag<T> buffer)
            => new Pipe<T>(buffer);
    }
}