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
        public static WorkflowStatus status(in Workflow wf, ArtifactIdentity worker, string description)
            => new WorkflowStatus(wf.Id, worker, description);        

        [MethodImpl(Inline), Op]
        public static WorkflowStatus status(ulong wfid, ArtifactIdentity worker, string description)
            => new WorkflowStatus(wfid, worker, description);        

        [MethodImpl(Inline)]
        public WorkflowStatus status<T>(in Workflow wf, string description)
            where T : struct, IWorkflowWorker<T>
                => status(wf, worker<T>().Id, description);        
    }
}