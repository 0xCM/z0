//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct WfCore    
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
        /// Defines an actor with a specified name, if given; otherwise the actor name is derived 
        /// from the path of the invoking member file
        /// </summary>
        /// <param name="name">The actor name</param>
        [MethodImpl(Inline), Op]
        public static WfWorker worker([CallerFilePath] string name = null)
            => WfWorker.create(name); 
    }
}