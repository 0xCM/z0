//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    public sealed class WorkflowCore : AssemblyResolution<WorkflowCore, WorkflowCore.C>
    {
        public WorkflowCore() : base(AssemblyId.WorkflowCore) {}
        
        public class C : OpCatalog<C> { public C() : base(AssemblyId.WorkflowCore) {} }            
    }
}