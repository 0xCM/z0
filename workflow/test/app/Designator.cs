//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    public sealed class WorkflowTest : AssemblyResolution<WorkflowTest>
    {
        public WorkflowTest() : base(AssemblyId.WorkflowTest) {}

        public override void Run(params string[] args) => App.Run(args);
    }
}