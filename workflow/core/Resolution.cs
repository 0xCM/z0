//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.WorkflowCore)]

namespace Z0.Resolutions
{
    public sealed class WorkflowCore : AssemblyResolution<WorkflowCore, WorkflowCore.C>
    {
        public WorkflowCore() : base(AssemblyId.WorkflowCore) {}
        
        public class C : AssemblyCatalog<C> { public C() : base(AssemblyId.WorkflowCore) {} }            
    }
}