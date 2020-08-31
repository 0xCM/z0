//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow
    {
        [Op, Closures(UnsignedInts)]
        public static void processed<T>(IWfContext wf, string actor, T kind, FilePath src, uint size, CorrelationToken ct)
            => wf.Raise(WfEvents.processed(actor, kind, src, size, ct));

        /// <summary>
        /// Defines an actor with a specified name, if given; otherwise the actor name is derived
        /// from the path of the invoking member file
        /// </summary>
        /// <param name="name">The actor name</param>
        [MethodImpl(Inline), Op]
        public static WfActor actor([CallerFilePath] string name = null)
            => WfActor.create(name);

        [Op, Closures(UnsignedInts)]
        public static void processing<T>(IWfShell wf, string actor, T kind, FilePath src, CorrelationToken ct)
            => wf.Raise(WfEvents.processing(actor,kind,src,ct));

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static void ran<T>(IWfShell wf, string worker, T body, CorrelationToken ct)
            => wf.Raise(new WfStepRan<T>(worker, body, ct));
    }
}