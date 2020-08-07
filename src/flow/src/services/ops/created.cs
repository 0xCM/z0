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
        [MethodImpl(Inline), Op]
        public static WorkerCreated created(string worker, CorrelationToken ct)
            => new WorkerCreated(worker, ct);                        

        /// <summary>
        /// Defines a <see cref='WfStepCreated'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static WfStepCreated created(WfStepId id, CorrelationToken ct, AppMsgColor flair = CreatedFlair)
            => new WfStepCreated(id,ct,flair);

        /// <summary>
        /// Defines a <see cref='WfStepCreated'/> event
        /// </summary>
        /// <param name="kind">The step kind</param>
        /// <param name="type">The name of the reifying type</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static WfStepCreated created<T>(WfStepKind kind, T type, CorrelationToken ct, AppMsgColor flair = CreatedFlair)
            => created(step(kind,type), ct, flair);

        /// <summary>
        /// Raises a <see cref='WfStepCreated'/> event
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="kind">The step kind</param>
        /// <param name="type">The name of the reifying type</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static void created<T>(IWfContext wf, WfStepKind kind, T type, CorrelationToken ct, AppMsgColor flair = CreatedFlair)
            => wf.Raise(created(kind,type,ct,flair));            
    }
}