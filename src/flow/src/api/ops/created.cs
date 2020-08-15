//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flairs;

    partial struct Flow    
    {
        /// <summary>
        /// Defines a <see cref='WorkerCreated'/> event
        /// </summary>
        /// <param name="ct">The correlation token</param>
        /// <param name="name">The actor name</param>
        [MethodImpl(Inline), Op]
        public static WorkerCreated wfWorkerCreated(CorrelationToken ct, [CallerFilePath] string name = null)
            => new WorkerCreated(WfCore.worker(name), ct);                        

        /// <summary>
        /// Defines a <see cref='WorkerCreated'/> event
        /// </summary>
        /// <param name="ct">The correlation token</param>
        /// <param name="worker">The actor</param>
        [MethodImpl(Inline), Op]
        public static WorkerCreated created(CorrelationToken ct, in WfWorker worker)
            => new WorkerCreated(worker, ct);                        

        /// <summary>
        /// Defines a <see cref='ActorCreated'/> event
        /// </summary>
        /// <param name="ct">The correlation token</param>
        /// <param name="actor">The actor</param>
        [MethodImpl(Inline), Op]
        public static ActorCreated created(CorrelationToken ct, in WfActor actor)
            => new ActorCreated(actor, ct);                        

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
        /// Defines a <see cref='WfStepCreated'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static WfStepCreated created(in WfActor actor, WfStepId id, CorrelationToken ct, MessageFlair flair = Created)
            => new WfStepCreated(actor, id, ct, flair);

        /// <summary>
        /// Defines a <see cref='WfStepCreated'/> event
        /// </summary>
        /// <param name="kind">The step kind</param>
        /// <param name="type">The name of the reifying type</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static WfStepCreated created<T>(WfStepKind kind, T type, CorrelationToken ct, MessageFlair flair = Created)
            => created(step(kind,type), ct, flair);

        /// <summary>
        /// Defines a <see cref='WfStepCreated'/> event
        /// </summary>
        /// <param name="kind">The step kind</param>
        /// <param name="type">The name of the reifying type</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static void created(IWfContext wf, in WfActor actor, WfStepId step, CorrelationToken ct, MessageFlair flair = Created)
            => wf.Raise(WfCore.created(actor,step,ct,flair));
            
        /// <summary>
        /// Raises a <see cref='WfStepCreated'/> event
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="kind">The step kind</param>
        /// <param name="type">The name of the reifying type</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static void created<T>(IWfContext wf, WfStepKind kind, T type, CorrelationToken ct, MessageFlair flair = Created)
            => wf.Raise(created(kind,type,ct,flair));            
    }
}