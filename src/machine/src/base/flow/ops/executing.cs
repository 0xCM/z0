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
        public StepExecuting executing(ulong wfid, ArtifactIdentity worker, string step, Timestamp ts)
            => new StepExecuting(wfid, worker, step, correlate(), ts);            

        [MethodImpl(Inline), Op]
        public StepExecuting executing(in Workflow wf, ArtifactIdentity worker, string step)
            => new StepExecuting(wf.Id, worker, step, correlate());

        [MethodImpl(Inline), Op]
        public StepExecuting executing(ulong wfid, ArtifactIdentity worker, string step)
            => new StepExecuting(wfid, worker, step, correlate());   

        [MethodImpl(Inline)]
        public StepExecuting executing<T>(in Workflow wf, string step)
            where T : struct, IWorkflowWorker<T>
                => executing(wf, worker<T>().Id, step);
    }
}