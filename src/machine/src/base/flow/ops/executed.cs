//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;

    partial struct Workflows
    {
        [MethodImpl(Inline), Op]
        public static StepExecuted executed(in Workflow wf, ArtifactIdentity  worker, string step, ulong ct)
            => new StepExecuted(wf.Id, worker, step, ct);        

        [MethodImpl(Inline), Op]
        public static StepExecuted executed(ulong wfid, ArtifactIdentity worker, string step, ulong ct)
            => new StepExecuted(wfid, worker, step, ct);

        [MethodImpl(Inline), Op]
        public static StepExecuted executed(ulong wfid, ArtifactIdentity worker, string step, ulong ct, Timestamp ts)
            => new StepExecuted(wfid, worker, step, ct, ts);

        [MethodImpl(Inline)]
        public StepExecuted executed<T>(in Workflow wf, string step, ulong ct)
            where T : struct, IWorkflowWorker<T>
                => executed(wf, worker<T>().Id, step, ct);        
    }
}