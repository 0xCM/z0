//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Pipes
    {
        static T identity<T>(T src)
            => src;

        [Op, Closures(Closure)]
        public static Pipe<T> pipe<T>(IWfShell wf)
            => pipe(wf, new PipeBuffer<T>(), new SFx.Projector<T>(identity));

        [Op, Closures(Closure)]
        public static Pipe<T> pipe<T>(IWfShell wf, SFx.IProjector<T> projector)
            => pipe(wf, new PipeBuffer<T>(), projector);

        public static Pipe<S,T> pipe<S,T>(IWfShell wf, SFx.IProjector<S,T> projector)
            => pipe<S,T>(wf, new PipeBuffer<S>(), projector);

        [MethodImpl(Inline)]
        internal static Pipe<S,T> pipe<S,T>(IWfShell wf, PipeBuffer<S> buffer, SFx.IProjector<S,T> fx)
            => new Pipe<S,T>(wf, buffer, fx);

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static Pipe<T> pipe<T>(IWfShell wf, PipeBuffer<T> buffer, SFx.IProjector<T> projector)
            => new Pipe<T>(wf, buffer, projector);
    }
}