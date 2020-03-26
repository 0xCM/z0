//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.WorkflowRuntime)]

namespace Z0.Parts
{        
    public sealed class WorkflowRuntime : ApiPart<WorkflowRuntime, WorkflowRuntime.C>
    {
        public class C : ApiCatalog<C> { public C() : base(PartId.WorkflowRuntime) { } }            
    }
}