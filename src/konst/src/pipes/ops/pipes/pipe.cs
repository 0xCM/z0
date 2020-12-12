//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static SFx;

    partial struct Pipes
    {
        static T identity<T>(T src)
            => src;

        [Op, Closures(Closure)]
        public static Pipe<T> pipe<T>()
            => pipe(new PipeBuffer<T>(), new Projector<T>(identity));

        [Op, Closures(Closure)]
        public static Pipe<T> pipe<T>(IProjector<T> projector)
            => pipe(new PipeBuffer<T>(), projector);

        public static Pipe<S,T> pipe<S,T>(IProjector<S,T> projector)
            => pipe<S,T>(new PipeBuffer<S>(), projector);

        [MethodImpl(Inline)]
        internal static Pipe<S,T> pipe<S,T>(PipeBuffer<S> buffer, IProjector<S,T> fx)
            => new Pipe<S,T>(buffer, fx);

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static Pipe<T> pipe<T>(PipeBuffer<T> buffer, IProjector<T> projector)
            => new Pipe<T>(buffer, projector);
    }
}