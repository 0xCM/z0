//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.WorkflowCore)]

namespace Z0.Parts
{
    public sealed class WorkflowCore : ApiPart<WorkflowCore, WorkflowCore.C>
    {
        public WorkflowCore() : base(PartId.WorkflowCore) {}
        
        public class C : ApiCatalog<C> { public C() : base(PartId.WorkflowCore) {} }            
    }
}