
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Z0.Asm;

    partial struct AppDataEmitter 
    {
        public readonly struct EmitDocs : IWorkflowWorker<EmitDocs>
        {
            readonly AppDataEmitter Workflow;

            public EmitDocs(AppDataEmitter wf)
            {
                Workflow = wf;
            }
            
            public void Run()
            {
                term.magenta("Emitting documentation");
                Commented.collect();
                term.magenta("Emitted documentation");
            }
        }
    }

}
