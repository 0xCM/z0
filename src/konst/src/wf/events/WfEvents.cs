//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static Render;
    using static AB;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;

    [ApiHost, Events]
    public readonly partial struct WfEvents
    {
        [MethodImpl(Inline)]
        static WfEventId<E> id<E>(WfStepId step, CorrelationToken ct)
            where E : struct, IWfEvent<E>
                => new WfEventId<E>(step, ct);

        [MethodImpl(Inline)]
        static WfEventId<E> id<E>(WfFunc fx, CorrelationToken ct)
            where E : struct, IWfEvent<E>
                => new WfEventId<E>(fx, ct);

        /// <summary>
        /// Defines a <see cref='WorkerCreated'/> event
        /// </summary>
        /// <param name="ct">The correlation token</param>
        /// <param name="name">The actor name</param>
        [MethodImpl(Inline), Op]
        public static WorkerCreated newWorker(CorrelationToken ct, [File] string name = null)
            => new WorkerCreated(Path.GetFileNameWithoutExtension(name), ct);
    }
}