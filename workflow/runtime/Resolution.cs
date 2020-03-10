//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.WorkflowRuntime)]

namespace Z0.Resolutions
{        
    public sealed class WorkflowRuntime : AssemblyResolution<WorkflowRuntime, WorkflowRuntime.C>
    {
        public WorkflowRuntime() : base(AssemblyId.WorkflowRuntime){}

        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.WorkflowRuntime) { } }            
    }
}