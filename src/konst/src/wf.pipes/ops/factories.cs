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
        public static DataPipe<S,T> create<S,T>()
            where S : struct
            where T : struct
                => create<S,T>(new ConcurrentBag<S>());

        [Op, Closures(AllNumeric)]
        public static DataPipe<T> create<T>()
            where T : struct
                => create(new ConcurrentBag<T>());

        [MethodImpl(Inline)]
        internal static DataPipe<S,T> create<S,T>(ConcurrentBag<S> buffer)
            where S : struct
            where T : struct
                => new DataPipe<S,T>(buffer);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        internal static DataPipe<T> create<T>(ConcurrentBag<T> buffer)
            where T : struct
                => new DataPipe<T>(buffer);

        [Op, Closures(AllNumeric)]
        static Pipe<T> value<T>()
            where T : unmanaged
                => value(new ConcurrentBag<T>());

        static Pipe<S,T> value<S,T>()
            where S : unmanaged
            where T : unmanaged
                => value<S,T>(new ConcurrentBag<S>());

        [MethodImpl(Inline)]
        internal static Pipe<S,T> value<S,T>(ConcurrentBag<S> buffer)
            where S : unmanaged
            where T : unmanaged
                => new Pipe<S,T>(buffer);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        internal static Pipe<T> value<T>(ConcurrentBag<T> buffer)
            where T : unmanaged
                => new Pipe<T>(buffer);
    }
}