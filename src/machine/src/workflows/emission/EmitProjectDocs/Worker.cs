
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Z0.Asm;

    partial struct EmissionWorkflow 
    {
        public readonly partial struct EmitProjectDocs : IWorkflowWorker<EmitProjectDocs>
        {
            readonly EmissionWorkflow Workflow;

            public EmitProjectDocs(EmissionWorkflow wf)
            {
                Workflow = wf;
            }
            
            public void Run()
            {
                term.magenta("Emitting project documentation");
                collect();
                term.magenta("Emitted project documentation");
            }
        }
    }
}
