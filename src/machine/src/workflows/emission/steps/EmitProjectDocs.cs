
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public readonly ref partial struct EmitProjectDocs
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
