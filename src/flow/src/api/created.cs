//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;

    partial struct Flow
    {
        /// <summary>
        /// Defines a <see cref='WorkerCreated'/> event
        /// </summary>
        /// <param name="ct">The correlation token</param>
        /// <param name="worker">The actor</param>
        [MethodImpl(Inline), Op]
        public static WorkerCreated created(CorrelationToken ct, in WfWorker worker)
            => new WorkerCreated(worker, ct);

        /// <summary>
        /// Defines a <see cref='WfStepCreated'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static WfStepCreated created(WfStepId id, CorrelationToken ct, MessageFlair flair = Created)
            => new WfStepCreated(id, ct, flair);

        /// <summary>
        /// Defines a <see cref='WfActorCreated'/> event
        /// </summary>
        /// <param name="ct">The correlation token</param>
        /// <param name="actor">The actor</param>
        [MethodImpl(Inline), Op]
        public static WfActorCreated created(CorrelationToken ct, in WfActor actor)
            => new WfActorCreated(actor, ct);
    }
}